/*
 * SettingsForm.cs
 * By Frank McCown
 * Summer 2010
 *
 * Feel free to modify this code.
 *
 *
 * Modified by dynamite
 * Winter 2022-2023
 * Free to play from Russia with love :)
 */

using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing;

namespace BatSpasScreensaver
{
    public partial class SettingsForm : Form
    {
        private int currentPreviewFrame = 1;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void linkLabel_batSpasAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://batspas.ru");
        }

        private void linkLabel_batUsage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://batspas.ru/bat/");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\dySoft\\BatSpasScreensaver");
            if ((key == null)||((int)key.GetValue("interval") < 10))
            {
                numericUpDown_playbackSpeed.Value = 10;
                timer_preview.Interval = 10;
                SaveSettings();
            }
            else
            {
                numericUpDown_playbackSpeed.Value = (int)key.GetValue("interval");
                timer_preview.Interval = (int)key.GetValue("interval");
            }
        }

        /// <summary>
        /// Save text into the Registry.
        /// </summary>
        private void SaveSettings()
        {
            // Create or get existing subkey
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\dySoft\\BatSpasScreensaver");
            if ((int)numericUpDown_playbackSpeed.Value < 10)
            {
                key.SetValue("interval", 10);
            }
            key.SetValue("interval", (int)numericUpDown_playbackSpeed.Value);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://creativecommons.org/licenses/by-sa/2.0/");
        }

        private void linkLabel_dynamite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://creativecommons.org/licenses/by/4.0/");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://creativecommons.org/licenses/by/4.0/");
        
        }

        private void timer_preview_Tick(object sender, EventArgs e)
        {
            if (currentPreviewFrame > 210)
            {
                currentPreviewFrame = 1;
            }

            //ResourceSet resSet = ScreenSaver.Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, false);
            pictureBox_preview.Image = (Image)BatSpasScreensaver.Properties.Resources.ResourceManager.GetObject(currentPreviewFrame.ToString("_0000"));
            currentPreviewFrame++;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            timer_preview.Tick += new EventHandler(timer_preview_Tick);
            LoadSettings();
            currentPreviewFrame = 1;
            timer_preview.Start();
        }

        private void numericUpDown_playbackSpeed_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void numericUpDown_playbackSpeed_ValueChanged(object sender, EventArgs e)
        {
            //if(timer_preview.)
            timer_preview.Interval = (int)numericUpDown_playbackSpeed.Value;
        }
    }
}
