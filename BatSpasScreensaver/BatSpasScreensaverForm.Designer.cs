
namespace BatSpasScreensaver
{
    partial class BatSpasScreensaverForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatSpasScreensaverForm));
            this.pictureBox_framesShow = new System.Windows.Forms.PictureBox();
            this.timer_fps = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_framesShow)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_framesShow
            // 
            this.pictureBox_framesShow.BackColor = System.Drawing.Color.Black;
            this.pictureBox_framesShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_framesShow.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_framesShow.Name = "pictureBox_framesShow";
            this.pictureBox_framesShow.Size = new System.Drawing.Size(870, 516);
            this.pictureBox_framesShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_framesShow.TabIndex = 2;
            this.pictureBox_framesShow.TabStop = false;
            // 
            // timer_fps
            // 
            this.timer_fps.Interval = 100;
            // 
            // BatSpasScreensaverForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(870, 516);
            this.Controls.Add(this.pictureBox_framesShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BatSpasScreensaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BatSpasScreensaverForm";
            this.Load += new System.EventHandler(this.BatSpasScreensaverForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BatSpasScreensaverForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BatSpasScreensaverForm_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BatSpasScreensaverForm_MouseDoubleClick);
            this.MouseHover += new System.EventHandler(this.BatSpasScreensaverForm_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BatSpasScreensaverForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_framesShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_framesShow;
        private System.Windows.Forms.Timer timer_fps;
    }
}

