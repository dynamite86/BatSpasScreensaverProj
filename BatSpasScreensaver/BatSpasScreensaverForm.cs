/*
 * ScreenSaverForm.cs
 * By Frank McCown
 * Summer 2010
 * 
 * Feel free to modify this code.
 *
 *
 * BatSpasScreensaverForm.cs
 * Modified by dynamite
 * Winter 2022-2023
 * Free to play from Russia with love :)
 */


using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace BatSpasScreensaver
{
    public partial class BatSpasScreensaverForm : Form
    {
        #region Win32 API functions

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        #endregion

        private bool previewMode = false;
        private int currentFrame = 1;

        public BatSpasScreensaverForm()
        {
            InitializeComponent();
        }
        public BatSpasScreensaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        public BatSpasScreensaverForm(IntPtr PreviewWndHandle)
        {
            InitializeComponent();

            // Set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);

            // Make this a child window so it will close when the parent dialog closes
            // GWL_STYLE = -16, WS_CHILD = 0x40000000
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            // Place our window inside the parent
            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            //scale
            pictureBox_framesShow.SizeMode = PictureBoxSizeMode.StretchImage;

            previewMode = true;
        }
        private void BatSpasScreensaverForm_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            TopMost = true;

            timer_fps.Tick += new EventHandler(TimerFpsTick);
            LoadSettings();
            currentFrame = 1;
            timer_fps.Start();
        }

        private void TimerFpsTick(object sender, System.EventArgs e)
        {
            if (currentFrame > 210)
            {
                currentFrame = 1;
            }

            //ResourceSet resSet = ScreenSaver.Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, false);
            pictureBox_framesShow.Image = (Image)BatSpasScreensaver.Properties.Resources.ResourceManager.GetObject(currentFrame.ToString("_0000"));
            currentFrame++;
        }

        private void LoadSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\dySoft\\BatSpasScreensaver");
            if (key == null)
            {
                timer_fps.Interval = 20;
            }
            else
            {
                timer_fps.Interval = (int)key.GetValue("interval");
            }
        }

        private void BatSpasScreensaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!previewMode)
                Application.Exit();
        }

        private void BatSpasScreensaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (!previewMode)
            {
                if (!mouseLocation.IsEmpty)
                {
                    // Terminate if mouse is moved a significant distance
                    if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                        Math.Abs(mouseLocation.Y - e.Y) > 5)
                        Application.Exit();
                }

                // Update current mouse location
                mouseLocation = e.Location;
            }*/
            if (!previewMode)
                Application.Exit();
        }

       private void BatSpasScreensaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (!previewMode)
                Application.Exit();
        }

        private void BatSpasScreensaverForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!previewMode)
                Application.Exit();
        }

        private void BatSpasScreensaverForm_MouseHover(object sender, EventArgs e)
        {
            if (!previewMode)
                Application.Exit();
        }
    }
}
