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
        long analysisTime;
        int threshold;
        bool useMask;
        bool excludeRegions;
        bool[][] mask;
        int videoWidth;
        int videoHeight;

        public List<DetectionObject> DetectionObjects { get; set; } = new List<DetectionObject>();
        public Bitmap BitmapReference { get; set; }
        public Bitmap BitmapCamera { get; set; }

        public int Threshold { get => threshold; set => threshold = value; }
        public bool ExcludeRegions { get => excludeRegions; set => excludeRegions = value; }
        public ulong DangerValue { get; set; }

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

                for (int y=0; y < videoHeight; y++)
                {
                    byte* currentLineCamera = PtrFirstPixelCamera + (y * bitmapDataCamera.Stride);
                    byte* currentLineReference = PtrFirstPixelReference + (y * bitmapDataCamera.Stride);

                    for (int x = 0; x < videoWidth; x++)
                    {
                        if (!useMask || mask[y][x] == true)
                        {
                            int offsetX = x * bytesPerPixel;

                            totalDifferenceWithReference += (ulong)Math.Abs(currentLineCamera[offsetX] - currentLineReference[offsetX]);
                            totalDifferenceWithReference += (ulong)Math.Abs(currentLineCamera[offsetX + 1] - currentLineReference[offsetX + 1]);
                            totalDifferenceWithReference += (ulong)Math.Abs(currentLineCamera[offsetX + 2] - currentLineReference[offsetX + 2]);

                            numScannedPixels++;
                        }
                    }
                }

                DangerValue = totalDifferenceWithReference / numScannedPixels;

                if(DangerValue <= 0 || DangerValue >10000)
                {
                    int k = 0;
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
        }
    }
}
