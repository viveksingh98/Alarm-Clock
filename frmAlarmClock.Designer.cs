namespace Alarm_Clock
{
    partial class formAlarmClock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAlarmClock));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBoxAlarms = new System.Windows.Forms.ListBox();
            this.btnStartAlarm = new System.Windows.Forms.Button();
            this.btnStopAlarm = new System.Windows.Forms.Button();
            this.btnSnooze = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxSnooze = new System.Windows.Forms.ComboBox();
            this.btnChooseMusic = new System.Windows.Forms.Button();
            this.btnClearAlarms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(45, 51);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // listBoxAlarms
            // 
            this.listBoxAlarms.FormattingEnabled = true;
            this.listBoxAlarms.Location = new System.Drawing.Point(45, 131);
            this.listBoxAlarms.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlarms.Name = "listBoxAlarms";
            this.listBoxAlarms.Size = new System.Drawing.Size(504, 147);
            this.listBoxAlarms.TabIndex = 1;
            // 
            // btnStartAlarm
            // 
            this.btnStartAlarm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStartAlarm.Location = new System.Drawing.Point(338, 51);
            this.btnStartAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartAlarm.Name = "btnStartAlarm";
            this.btnStartAlarm.Size = new System.Drawing.Size(70, 44);
            this.btnStartAlarm.TabIndex = 2;
            this.btnStartAlarm.Text = "Start";
            this.btnStartAlarm.UseVisualStyleBackColor = false;
            this.btnStartAlarm.Click += new System.EventHandler(this.btnStartAlarm_Click);
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.BackColor = System.Drawing.Color.IndianRed;
            this.btnStopAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopAlarm.Location = new System.Drawing.Point(464, 51);
            this.btnStopAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(71, 44);
            this.btnStopAlarm.TabIndex = 3;
            this.btnStopAlarm.Text = "Stop";
            this.btnStopAlarm.UseVisualStyleBackColor = false;
            this.btnStopAlarm.Click += new System.EventHandler(this.btnStopAlarm_Click);
            // 
            // btnSnooze
            // 
            this.btnSnooze.BackColor = System.Drawing.Color.Gold;
            this.btnSnooze.Location = new System.Drawing.Point(170, 301);
            this.btnSnooze.Margin = new System.Windows.Forms.Padding(2);
            this.btnSnooze.Name = "btnSnooze";
            this.btnSnooze.Size = new System.Drawing.Size(74, 35);
            this.btnSnooze.TabIndex = 4;
            this.btnSnooze.Text = "Snooze";
            this.btnSnooze.UseVisualStyleBackColor = false;
            this.btnSnooze.Click += new System.EventHandler(this.btnSnooze_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = " ";
            // 
            // comboBoxSnooze
            // 
            this.comboBoxSnooze.FormattingEnabled = true;
            this.comboBoxSnooze.Location = new System.Drawing.Point(45, 310);
            this.comboBoxSnooze.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSnooze.Name = "comboBoxSnooze";
            this.comboBoxSnooze.Size = new System.Drawing.Size(92, 21);
            this.comboBoxSnooze.TabIndex = 5;
            // 
            // btnChooseMusic
            // 
            this.btnChooseMusic.Location = new System.Drawing.Point(45, 87);
            this.btnChooseMusic.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseMusic.Name = "btnChooseMusic";
            this.btnChooseMusic.Size = new System.Drawing.Size(150, 24);
            this.btnChooseMusic.TabIndex = 6;
            this.btnChooseMusic.Text = "Choose Music";
            this.btnChooseMusic.UseVisualStyleBackColor = true;
            this.btnChooseMusic.Click += new System.EventHandler(this.btnChooseMusic_Click);
            // 
            // btnClearAlarms
            // 
            this.btnClearAlarms.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAlarms.Location = new System.Drawing.Point(464, 301);
            this.btnClearAlarms.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAlarms.Name = "btnClearAlarms";
            this.btnClearAlarms.Size = new System.Drawing.Size(85, 35);
            this.btnClearAlarms.TabIndex = 7;
            this.btnClearAlarms.Text = "Clear Alarms";
            this.btnClearAlarms.UseVisualStyleBackColor = false;
            this.btnClearAlarms.Click += new System.EventHandler(this.btnClearAlarms_Click);
            // 
            // formAlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnClearAlarms);
            this.Controls.Add(this.btnChooseMusic);
            this.Controls.Add(this.comboBoxSnooze);
            this.Controls.Add(this.btnSnooze);
            this.Controls.Add(this.btnStopAlarm);
            this.Controls.Add(this.btnStartAlarm);
            this.Controls.Add(this.listBoxAlarms);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formAlarmClock";
            this.Text = "Vivek\'s Alarm Clock";
            this.Load += new System.EventHandler(this.formAlarmClock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBoxAlarms;
        private System.Windows.Forms.Button btnStartAlarm;
        private System.Windows.Forms.Button btnStopAlarm;
        private System.Windows.Forms.Button btnSnooze;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBoxSnooze;
        private System.Windows.Forms.Button btnChooseMusic;
        private System.Windows.Forms.Button btnClearAlarms;
    }
}

