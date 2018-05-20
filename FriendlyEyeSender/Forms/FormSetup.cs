using dshow;
using dshow.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoSource;

namespace FriendlyEyeSender.Forms
{
    public partial class FormSetup : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndIntertAfter, int X, int Y, int cx, int cy, int uFlags);
        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int Which);

        private Camera camera = null;

        private static System.Windows.Forms.Timer updateScreenTimer;
        private static Object locker = new Object();
        bool mouseDown = false;
        Point mouseDownPoint = Point.Empty;
        Point mouseUpPoint = Point.Empty;

        bool createNewReferenceImage = false;

        int currentObjectNumber = 1;
        DetectionObject currentObject = null;
        DetectionSystem detectionSystem = new DetectionSystem();
        bool isProcessing;

        SoundPlayer soundPlayer = new SoundPlayer();

        public Form MyParent { get; set; }

        private void SetupTimer()
        {
            // Create a timer with a 100 msec interval.
            updateScreenTimer = new System.Windows.Forms.Timer();
            updateScreenTimer.Interval = 80;
            updateScreenTimer.Tick += new EventHandler(OnTimedEventUpdateScreen);
            updateScreenTimer.Start();
        }

        private void OnTimedEventUpdateScreen(object sender, EventArgs eArgs)
        {
            UpdateDangerText();

            pictureBoxCamera.Invalidate();
        }

        private void UpdateDangerText()
        {
            outlineLabelDangerValue.Text = detectionSystem.DangerValue.ToString();

            if (detectionSystem.DangerValue > detectionSystem.Threshold)
            {
                outlineLabelDanger.Visible = true;
            }
            else
            {
                outlineLabelDanger.Visible = false;
            }
        }

        public FormSetup()
        {
            createNewReferenceImage = true;
            InitializeComponent();
            setCaptureDevice();
            SetupTimer();
            outlineLabelSensitivity.Parent = pictureBoxCamera;
            outlineLabelSensitivity.BackColor = Color.Transparent;
            outlineLabelDangerLabel.Parent = pictureBoxCamera;
            outlineLabelDangerLabel.BackColor = Color.Transparent;
            outlineLabelDangerValue.Parent = pictureBoxCamera;
            outlineLabelDangerValue.BackColor = Color.Transparent;
            outlineLabelCurrentObject.Parent = pictureBoxCamera;
            outlineLabelCurrentObject.BackColor = Color.Transparent;
            outlineLabelThreshold.Parent = pictureBoxCamera;
            outlineLabelThreshold.BackColor = Color.Transparent;
            outlineLabelDanger.Parent = pictureBoxCamera;
            outlineLabelDanger.BackColor = Color.Transparent;
            UpdateRegionButtons();
            detectionSystem.Threshold = Convert.ToInt32(numericUpDownThreshold.Value); 

            // Go Fullscreen
            /*
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            SetWindowPos(Handle, IntPtr.Zero, 0, 0, GetSystemMetrics(0), GetSystemMetrics(1), 64);
            */
            
        }

        private void buttonSetup_Click(object sender, EventArgs e)
        {
            createNewReferenceImage = true;
            CloseFile();
            Close();
        }

        private void setCaptureDevice()
        {
            // Set capture device
            try
            {
                FilterCollection filters = new FilterCollection(FilterCategory.VideoInputDevice);
                string device = filters[0].MonikerString;

                if (filters.Count == 0)
                {
                    throw new ApplicationException();
                }

                // create video source
                CaptureDevice localSource = new CaptureDevice();
                localSource.VideoSource = device;

                // open it
                OpenVideoSource(localSource);
            }
            catch (ApplicationException e)
            {
                MessageBox.Show("No video source available!");
                Console.WriteLine(e.Message);
            }

        }

        private Rectangle RectCameraToScreen(Rectangle rect)
        {
            int x = (int)(rect.X * (float)pictureBoxCamera.Width / camera.Width);
            int y = (int)(rect.Y * (float)pictureBoxCamera.Height / camera.Height);
            int width = (int)(rect.Width * (float)pictureBoxCamera.Width / camera.Width);
            int height = (int)(rect.Height * (float)pictureBoxCamera.Height / camera.Height);

            return new Rectangle(x, y, width, height);
        }

        private Rectangle RectScreenToCamera(Rectangle scaledRect)
        {
            int x = (int)(scaledRect.X * (float)camera.Width / pictureBoxCamera.Width);
            int y = (int)(scaledRect.Y * (float)camera.Height / pictureBoxCamera.Height);
            int width = (int)(scaledRect.Width * (float)camera.Width / pictureBoxCamera.Width);
            int height = (int)(scaledRect.Height * (float)camera.Height / pictureBoxCamera.Height);

            return new Rectangle(x, y, width, height);
        }

        // Close current file
        private void CloseFile()
        {
            if (camera != null)
            {
                // signal camera to stop
                camera.SignalToStop();
                // wait for the camera
                camera.WaitForStop();

                camera = null;
            }
        }

        // On new frame
        private void camera_NewFrame(object sender, System.EventArgs e)
        {
            if (isProcessing)
                return;
            isProcessing = true;

            try
            {
                camera.Lock();

                if (camera.LastFrame != null)
                {
          //          lock (locker)
                    {
                        if (createNewReferenceImage)
                        {
                            createNewReferenceImage = false;
                            detectionSystem.BitmapReference = new Bitmap(camera.LastFrame);
                            detectionSystem.DangerValueReference = 0;
                            detectionSystem.NumReferenceValues = 0;
                        }
                        detectionSystem.BitmapCamera = camera.LastFrame;
                        detectionSystem.Analyze();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                camera.Unlock();
                isProcessing = false;
            }

            // TODO : make sure this gets called on the form thread to prevent queueing messages.. pictureBoxCamera.Invalidate();
        }


        // Open video source
        private void OpenVideoSource(IVideoSource source)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // close previous file
            CloseFile();

            // create camera
            camera = new Camera(source);
            // start camera
            camera.Start();

            // set event handlers
            camera.NewFrame += new EventHandler(camera_NewFrame);

            this.Cursor = Cursors.Default;
        }

        private void buttonWatch_Click(object sender, EventArgs e)
        {
            buttonWatch.ForeColor = Color.Lime;
            buttonExclude.ForeColor = Color.LightGray;
            detectionSystem.ExcludeRegions = false;
            detectionSystem.UpdateMask();
            createNewReferenceImage = true;     // seems to be necessary
        }

        private void buttonExclude_Click(object sender, EventArgs e)
        {
            buttonWatch.ForeColor = Color.LightGray;
            buttonExclude.ForeColor = Color.Red;
            detectionSystem.ExcludeRegions = true;
            detectionSystem.UpdateMask();
            createNewReferenceImage = true;     // seems to be necessary
        }

        private void pictureBoxCamera_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseUpPoint = mouseDownPoint = e.Location;
        }

        private void pictureBoxCamera_MouseMove(object sender, MouseEventArgs e)
        {
            mouseUpPoint = e.Location;
            pictureBoxCamera.Invalidate();
        }

        private void pictureBoxCamera_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp();
        }

        private void MouseUp()
        {
            mouseDown = false;
            currentObject = new DetectionObject(RectScreenToCamera(new Rectangle(Math.Min(mouseDownPoint.X, mouseUpPoint.X),
                    Math.Min(mouseDownPoint.Y, mouseUpPoint.Y),
                    Math.Max(mouseDownPoint.X, mouseUpPoint.X) - Math.Min(mouseDownPoint.X, mouseUpPoint.X),
                    Math.Max(mouseDownPoint.Y, mouseUpPoint.Y) - Math.Min(mouseDownPoint.Y, mouseUpPoint.Y))));
            detectionSystem.DetectionObjects.Add(currentObject);
            currentObjectNumber = detectionSystem.DetectionObjects.Count;
            Cursor = Cursors.Default;
            UpdateRegionButtons();
            detectionSystem.UpdateMask();
            createNewReferenceImage = true;     // seems to be necessary
        }

        private void UpdateRegionButtons()
        {
            outlineLabelCurrentObject.Text = currentObjectNumber.ToString();
            if (detectionSystem.DetectionObjects.Count > 0)
            {
                outlineLabelCurrentObject.Visible = true;
                buttonPreviousRegion.Visible = true;
                buttonNextRegion.Visible = true;
                buttonRemoveRegion.Visible = true;
            }
            else
            {
                outlineLabelCurrentObject.Visible = false;
                buttonPreviousRegion.Visible = false;
                buttonNextRegion.Visible = false;
                buttonRemoveRegion.Visible = false;
            }
            pictureBoxCamera.Invalidate();
        }

        private void buttonNextRegion_Click(object sender, EventArgs e)
        {
            if (currentObjectNumber < detectionSystem.DetectionObjects.Count)
            {
                currentObjectNumber++;
                currentObject = detectionSystem.DetectionObjects.ElementAtOrDefault(currentObjectNumber - 1);
                UpdateRegionButtons();
            }
        }

        private void buttonPreviousRegion_Click(object sender, EventArgs e)
        {
            if (currentObjectNumber > 1)
            {
                currentObjectNumber--;
                currentObject = detectionSystem.DetectionObjects.ElementAtOrDefault(currentObjectNumber - 1);
                UpdateRegionButtons();
            }
        }

        private void buttonRemoveRegion_Click(object sender, EventArgs e)
        {
            if (detectionSystem.DetectionObjects.Count > 0)
            {
                detectionSystem.DetectionObjects.RemoveAt(currentObjectNumber - 1);
                if (currentObjectNumber > detectionSystem.DetectionObjects.Count)       // we are at the last object, so move one back
                {
                    currentObjectNumber--;
                }
                currentObject = detectionSystem.DetectionObjects.ElementAtOrDefault(currentObjectNumber - 1);
                UpdateRegionButtons();
            }
            detectionSystem.UpdateMask();
            createNewReferenceImage = true;     // seems to be necessary
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            CloseFile();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createNewReferenceImage = true;
        }

        private void numericUpDownThreshold_ValueChanged(object sender, EventArgs e)
        {
            detectionSystem.SizeAnalysisChunks = 101 - Convert.ToInt32(numericUpDownSensitivity.Value);
            createNewReferenceImage = true;     // seems to be necessary
        }

        private void numericUpDownThreshold_ValueChanged_1(object sender, EventArgs e)
        {
            detectionSystem.Threshold = Convert.ToInt32(numericUpDownThreshold.Value);
        }

        private void pictureBoxCamera_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc = pictureBoxCamera.ClientRectangle;

            if (camera != null)
            {
                try
                {
                    camera.Lock();

                    // draw frame
                    if (camera.LastFrame != null)
                    {
                        e.Graphics.DrawImage(camera.LastFrame, rc.X, rc.Y, rc.Width - 1, rc.Height - 1);
                    }
                    else
                    {
                        // Create font and brush
                        Font drawFont = new Font("Arial", 12);
                        SolidBrush drawBrush = new SolidBrush(Color.White);

                        e.Graphics.DrawString("Connecting ...", drawFont, drawBrush, new PointF(5, 5));

                        drawBrush.Dispose();
                        drawFont.Dispose();
                    }
                }
                catch (Exception)
                {
                }
                finally
                {
                    camera.Unlock();
                }

                Pen redPen = new Pen(Color.Red, 6);
                Pen limePen = new Pen(Color.Lime, 6);
                Pen bigWhitePen = new Pen(Color.White, 6);
                Pen whitePen = new Pen(Color.White, 2);
                Pen blackPen = new Pen(Color.Black, 2);
                if (mouseDown)
                {
                    Rectangle window = new Rectangle(
                        Math.Min(mouseDownPoint.X, mouseUpPoint.X),
                        Math.Min(mouseDownPoint.Y, mouseUpPoint.Y),
                        Math.Abs(mouseDownPoint.X - mouseUpPoint.X),
                        Math.Abs(mouseDownPoint.Y - mouseUpPoint.Y));
                    e.Graphics.DrawRectangle(bigWhitePen, window);
                    e.Graphics.DrawRectangle(blackPen, window);
                }
                foreach (DetectionObject detectionObject in detectionSystem.DetectionObjects)
                {
                    if (detectionSystem.ExcludeRegions)
                    {
                        e.Graphics.DrawRectangle(redPen, RectCameraToScreen(detectionObject.Rectangle));
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(limePen, RectCameraToScreen(detectionObject.Rectangle));
                    }
                    if (detectionObject == currentObject)
                    {
                        e.Graphics.DrawRectangle(whitePen, RectCameraToScreen(detectionObject.Rectangle));
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(blackPen, RectCameraToScreen(detectionObject.Rectangle));
                    }
                }
            }
        }
    }
}
