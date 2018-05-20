using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace FriendlyEyeSender
{
    class DetectionSystem
    {
        const int NUM_REFERENCE_SAMPLES = 5;
        long analysisTime;
        int sizeAnalysisChunks = 1;
        bool useMask;
        bool excludeRegions;
        bool[][] mask;
        int videoWidth;
        int videoHeight;
        int analysisMode;
        int numReferenceValues;
        int threshold;

        public List<DetectionObject> DetectionObjects { get; set; } = new List<DetectionObject>();
        public Bitmap BitmapReference { get; set; }
        public Bitmap BitmapCamera { get; set; }

        public int SizeAnalysisChunks { get => sizeAnalysisChunks; set => sizeAnalysisChunks = value; }
        public bool ExcludeRegions { get => excludeRegions; set => excludeRegions = value; }
        public int DangerValue { get; set; }
        public int DangerValueReference { get; set; }
        public int NumReferenceValues { get => numReferenceValues; set => numReferenceValues = value; }
        public int Threshold { get => threshold; set => threshold = value; }

        public void UpdateMask()
        {
            if (videoHeight < 1)
            {
                return;     // camera not initialized yet
            }

            mask = new bool[videoHeight][];

            // clear mask
            for (int y=0; y < videoHeight; y++ )
            {
                mask[y] = new bool[videoWidth];
                for (int x = 0; x < videoWidth; x++)
                {
                    mask[y][x] = excludeRegions;
                }
            }

            // set mask
            foreach(DetectionObject O in DetectionObjects)
            {
                for(int y = O.Rectangle.Y; y < O.Rectangle.Bottom; y++)
                {
                    for(int x = O.Rectangle.X; x < O.Rectangle.Right; x++)
                    {
                        mask[y][x] = !excludeRegions;
                    }
                }
            }

            if(DetectionObjects.Count>0)        // only use mask if there are regions
            {
                useMask = true;
            }
            else
            {
                useMask = false;
            }
        }

        unsafe public void Analyze()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            BitmapData bitmapDataCamera = null;
            BitmapData bitmapDataReference = null;
            try
            {
                bitmapDataReference = BitmapReference.LockBits(new Rectangle(0, 0, BitmapReference.Width, BitmapReference.Height), ImageLockMode.ReadOnly, BitmapReference.PixelFormat);
                bitmapDataCamera = BitmapCamera.LockBits(new Rectangle(0, 0, BitmapCamera.Width, BitmapCamera.Height), ImageLockMode.ReadOnly, BitmapCamera.PixelFormat);
                videoHeight = BitmapCamera.Height;
                videoWidth = BitmapCamera.Width;
                ulong numScannedPixels = 0;
                ulong totalDifferenceWithReference = 0;
                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(BitmapCamera.PixelFormat) / 8;

                byte* PtrFirstPixelCamera = (byte*)bitmapDataCamera.Scan0;
                byte* PtrFirstPixelReference = (byte*)bitmapDataReference.Scan0;

                for (int y = 0; y < videoHeight - (sizeAnalysisChunks - 1); y+= sizeAnalysisChunks)
                {
                    for (int x = 0; x < videoWidth - (sizeAnalysisChunks - 1); x += sizeAnalysisChunks)
                    {
                        int redCamera = 0, redReference = 0;
                        int greenCamera = 0, greenReference = 0;
                        int blueCamera = 0, blueReference = 0;
                        for (int y_sub = 0; y_sub < sizeAnalysisChunks; y_sub++)
                        {
                            int y_abs = y + y_sub;
                            byte* currentLineCamera = PtrFirstPixelCamera + (y_abs * bitmapDataCamera.Stride);
                            byte* currentLineReference = PtrFirstPixelReference + (y_abs * bitmapDataCamera.Stride);
                            for (int x_sub = 0; x_sub < sizeAnalysisChunks; x_sub++)
                            {
                                int x_abs = x + x_sub;
                                if (!useMask || mask[y_abs][x_abs] == true)
                                {
                                    int offsetX = x_abs * bytesPerPixel;

                                    redCamera += currentLineCamera[offsetX];
                                    redReference += currentLineReference[offsetX];
                                    greenCamera += currentLineCamera[offsetX+1];
                                    greenReference += currentLineReference[offsetX+1];
                                    blueCamera += currentLineCamera[offsetX+2];
                                    blueReference += currentLineReference[offsetX+2];

                                    numScannedPixels++;
                                }
                            }
                        }
                        totalDifferenceWithReference += (ulong)Math.Abs(redCamera - redReference);
                        totalDifferenceWithReference += (ulong)Math.Abs(greenCamera - greenReference);
                        totalDifferenceWithReference += (ulong)Math.Abs(blueCamera - blueReference);
                    }
                }

                if (numReferenceValues < NUM_REFERENCE_SAMPLES)
                {
                    numReferenceValues++;
                    DangerValue = 0;
                    DangerValueReference += (int)(totalDifferenceWithReference / numScannedPixels);
                    if (numReferenceValues == NUM_REFERENCE_SAMPLES)
                    {
                        DangerValueReference /= NUM_REFERENCE_SAMPLES;
                    }
                }
                else
                {
                    DangerValue = DangerValueReference-((int)(totalDifferenceWithReference / numScannedPixels));
                    if(DangerValue<0)
                    {
                        DangerValue = -DangerValue;
                    }
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                BitmapCamera.UnlockBits(bitmapDataCamera);
                BitmapReference.UnlockBits(bitmapDataReference);
            }

            watch.Stop();
            analysisTime = watch.ElapsedMilliseconds;
            Console.WriteLine(analysisTime);
        }
    }
}
