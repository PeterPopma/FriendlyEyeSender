using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendlyEyeSender.Forms
{
    public partial class FormCountdown : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndIntertAfter, int X, int Y, int cx, int cy, int uFlags);
        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int Which);

        private static System.Windows.Forms.Timer updateScreenTimer;
        DateTime timeDangerStarted;
        int MAX_WARNING_SECONDS = 10;
        string telephone;
        string address;

        public string Telephone { get => telephone; set => telephone = value; }
        public string Address { get => address; set => address = value; }

        public FormCountdown()
        {
            InitializeComponent();
            SetupTimer();
            timeDangerStarted = DateTime.Now;
            // Go Fullscreen
/*            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            SetWindowPos(Handle, IntPtr.Zero, 0, 0, GetSystemMetrics(0), GetSystemMetrics(1), 64);*/
        }

        private void SetupTimer()
        {
            // Create a timer with a 10 msec interval.
            updateScreenTimer = new System.Windows.Forms.Timer();
            updateScreenTimer.Interval = 10;
            updateScreenTimer.Tick += new EventHandler(OnTimedEventUpdateScreen);
            updateScreenTimer.Start();
        }

        private void OnTimedEventUpdateScreen(object sender, EventArgs eArgs)
        {
            int secondsInDanger = (DateTime.Now - timeDangerStarted).Seconds;
            labelCountdown.Text = (MAX_WARNING_SECONDS - secondsInDanger).ToString();
            if (secondsInDanger > MAX_WARNING_SECONDS)
            {
                updateScreenTimer.Stop();
                FormWarning formWarning = new FormWarning();
                formWarning.Show();
                updateScreenTimer.Stop();
                Close();
            }
        }

        private void FormCountdown_Shown(object sender, EventArgs e)
        {
//            new KPNClient().PostSMS(Telephone, Address);       // send out SMS to owner
        }
    }
}
