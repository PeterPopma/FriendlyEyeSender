using dshow;
using dshow.Core;
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
using VideoSource;

namespace FriendlyEyeSender.Forms
{
    public partial class FormMain : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndIntertAfter, int X, int Y, int cx, int cy, int uFlags);
        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int Which);

        public FormMain()
        {
            InitializeComponent();

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
            FormSetup formSetup = new FormSetup();
            formSetup.MyParent = this;
            formSetup.Show();
        }

    }
}
