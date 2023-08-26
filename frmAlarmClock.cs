using System;
using System.Configuration;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

namespace Alarm_Clock
{
    public partial class formAlarmClock : Form
    {
        private Timer timer;
        private VlcControl vlcControl;
        private string selectedFilePath = string.Empty;

        public formAlarmClock()
        {
            InitializeComponent();

            // Check if VLC path is already saved
            string vlcPath = ConfigurationManager.AppSettings["VlcPath"];
            if (string.IsNullOrEmpty(vlcPath))
            {
                FolderBrowserDialog folderDialog = new FolderBrowserDialog();
                folderDialog.Description = "Select the VLC installation directory";
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    vlcPath = folderDialog.SelectedPath;

                    // Save to app settings
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["VlcPath"].Value = vlcPath;
                    config.Save(ConfigurationSaveMode.Modified);
                }
            }

            // Initialize VLC control
            vlcControl = new VlcControl();
            this.Controls.Add(vlcControl);
            vlcControl.VlcLibDirectory = new System.IO.DirectoryInfo(vlcPath);
            vlcControl.EndInit();

            // Initialize Timer
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void formAlarmClock_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dateTimePicker1.ShowUpDown = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            comboBoxSnooze.Items.AddRange(new string[] { "5", "10", "15", "20", "25", "30" });
            comboBoxSnooze.SelectedIndex = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString("HH:mm:ss") == dateTimePicker1.Value.ToString("HH:mm:ss"))
            {
                timer.Stop();
                try
                {
                    vlcControl.SetMedia(new Uri(selectedFilePath));
                    vlcControl.Play();
                }
                catch (System.NullReferenceException nullEx)
                {
                    MessageBox.Show($"NullReferenceException: {nullEx.Message}\n{nullEx.StackTrace}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to play the alarm: {ex.Message}\n{ex.StackTrace}");
                }
            }
        }

        private void btnStartAlarm_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value <= DateTime.Now)
                {
                    MessageBox.Show("Please select a time in the future.");
                    return;
                }

                listBoxAlarms.Items.Add(dateTimePicker1.Value.ToString("HH:mm:ss"));
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to start the alarm: {ex.Message}");
            }
        }

        private void btnChooseMusic_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "MP4 Files|*.mp4|MP3 Files|*.mp3";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to browse the file: {ex.Message}");
            }
        }

        private void btnStopAlarm_Click(object sender, EventArgs e)
        {
            vlcControl.Stop();
        }

        private void btnSnooze_Click(object sender, EventArgs e)
        {
            timer.Stop();  // Stop the timer first
            vlcControl.Stop();  // Stop the media playback
            DateTime snoozeTime = DateTime.Now.AddMinutes(int.Parse(comboBoxSnooze.SelectedItem.ToString()));
            dateTimePicker1.Value = snoozeTime;
            timer.Start();  // Start the timer again
        }

        private void btnClearAlarms_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxAlarms.Items.Clear(); // Clears all listed alarms
                timer.Stop(); // Stops the timer
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to clear alarms: {ex.Message}");
            }
        }
    }
}
