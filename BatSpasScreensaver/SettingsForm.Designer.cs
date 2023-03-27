
namespace BatSpasScreensaver
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.numericUpDown_playbackSpeed = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.pictureBox_preview = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel_batUsage = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel_original = new System.Windows.Forms.LinkLabel();
            this.linkLabel_dynamite = new System.Windows.Forms.LinkLabel();
            this.linkLabel_NeEdward = new System.Windows.Forms.LinkLabel();
            this.timer_preview = new System.Windows.Forms.Timer(this.components);
            this.label_freeware = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_playbackSpeed)).BeginInit();
            this.groupBox_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Домашняя страничка команды спасателей летучих мышек:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(547, 74);
            this.linkLabel1.MaximumSize = new System.Drawing.Size(0, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://batspas.ru/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_batSpasAbout_LinkClicked);
            // 
            // numericUpDown_playbackSpeed
            // 
            this.numericUpDown_playbackSpeed.Location = new System.Drawing.Point(366, 19);
            this.numericUpDown_playbackSpeed.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_playbackSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_playbackSpeed.Name = "numericUpDown_playbackSpeed";
            this.numericUpDown_playbackSpeed.Size = new System.Drawing.Size(288, 20);
            this.numericUpDown_playbackSpeed.TabIndex = 14;
            this.numericUpDown_playbackSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_playbackSpeed.ValueChanged += new System.EventHandler(this.numericUpDown_playbackSpeed_ValueChanged);
            this.numericUpDown_playbackSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numericUpDown_playbackSpeed_Scroll);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(597, 354);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(12, 354);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Скорость воспроизведения, кадров в секунду (10...60):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Код:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(146, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "BatSpas Screensaver";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseMnemonic = false;
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Controls.Add(this.label3);
            this.groupBox_settings.Controls.Add(this.numericUpDown_playbackSpeed);
            this.groupBox_settings.Location = new System.Drawing.Point(12, 283);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(660, 52);
            this.groupBox_settings.TabIndex = 17;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Настройки";
            // 
            // pictureBox_preview
            // 
            this.pictureBox_preview.Image = global::BatSpasScreensaver.Properties.Resources._0001;
            this.pictureBox_preview.Location = new System.Drawing.Point(12, 13);
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_preview.TabIndex = 18;
            this.pictureBox_preview.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Версия:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(203, 42);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(71, 13);
            this.label_version.TabIndex = 20;
            this.label_version.Text = "0.0.0.7 (Beta)";
            this.label_version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Если вы нашли летучую мышь, то обязательно прочитайте эту инструкцию:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel_batUsage
            // 
            this.linkLabel_batUsage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel_batUsage.AutoSize = true;
            this.linkLabel_batUsage.Location = new System.Drawing.Point(547, 101);
            this.linkLabel_batUsage.Name = "linkLabel_batUsage";
            this.linkLabel_batUsage.Size = new System.Drawing.Size(112, 13);
            this.linkLabel_batUsage.TabIndex = 21;
            this.linkLabel_batUsage.TabStop = true;
            this.linkLabel_batUsage.Text = "http://batspas.ru/bat/";
            this.linkLabel_batUsage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_batUsage_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "1)Frank McCown © 2010...2012";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "2)dynamite © 2022...2023";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ne.Edward © 2022...2023";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "3D-визуализация:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel_original
            // 
            this.linkLabel_original.AutoSize = true;
            this.linkLabel_original.Location = new System.Drawing.Point(185, 169);
            this.linkLabel_original.Name = "linkLabel_original";
            this.linkLabel_original.Size = new System.Drawing.Size(210, 13);
            this.linkLabel_original.TabIndex = 27;
            this.linkLabel_original.TabStop = true;
            this.linkLabel_original.Text = "Creative Commons License (CC BY-SA 2.0)";
            this.linkLabel_original.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel_dynamite
            // 
            this.linkLabel_dynamite.AutoSize = true;
            this.linkLabel_dynamite.Location = new System.Drawing.Point(185, 182);
            this.linkLabel_dynamite.Name = "linkLabel_dynamite";
            this.linkLabel_dynamite.Size = new System.Drawing.Size(193, 13);
            this.linkLabel_dynamite.TabIndex = 28;
            this.linkLabel_dynamite.TabStop = true;
            this.linkLabel_dynamite.Text = "Creative Commons License (CC BY 4.0)";
            this.linkLabel_dynamite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_dynamite_LinkClicked);
            // 
            // linkLabel_NeEdward
            // 
            this.linkLabel_NeEdward.AutoSize = true;
            this.linkLabel_NeEdward.Location = new System.Drawing.Point(185, 224);
            this.linkLabel_NeEdward.Name = "linkLabel_NeEdward";
            this.linkLabel_NeEdward.Size = new System.Drawing.Size(193, 13);
            this.linkLabel_NeEdward.TabIndex = 29;
            this.linkLabel_NeEdward.TabStop = true;
            this.linkLabel_NeEdward.Text = "Creative Commons License (CC BY 4.0)";
            this.linkLabel_NeEdward.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // timer_preview
            // 
            this.timer_preview.Tick += new System.EventHandler(this.timer_preview_Tick);
            // 
            // label_freeware
            // 
            this.label_freeware.AutoSize = true;
            this.label_freeware.Location = new System.Drawing.Point(13, 252);
            this.label_freeware.Name = "label_freeware";
            this.label_freeware.Size = new System.Drawing.Size(570, 13);
            this.label_freeware.TabIndex = 30;
            this.label_freeware.Text = "Данный продукт является свободным для распространения (см. подробности выше по сс" +
    "ылкам на лицензии)";
            this.label_freeware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.label_freeware);
            this.Controls.Add(this.linkLabel_NeEdward);
            this.Controls.Add(this.linkLabel_dynamite);
            this.Controls.Add(this.linkLabel_original);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel_batUsage);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox_preview);
            this.Controls.Add(this.groupBox_settings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 430);
            this.MinimumSize = new System.Drawing.Size(700, 430);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки BatSpas Screensaver";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_playbackSpeed)).EndInit();
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NumericUpDown numericUpDown_playbackSpeed;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.PictureBox pictureBox_preview;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel_batUsage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel_original;
        private System.Windows.Forms.LinkLabel linkLabel_dynamite;
        private System.Windows.Forms.LinkLabel linkLabel_NeEdward;
        private System.Windows.Forms.Timer timer_preview;
        private System.Windows.Forms.Label label_freeware;
    }
}