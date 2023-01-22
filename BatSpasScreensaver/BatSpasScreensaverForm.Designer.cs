
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
            resources.ApplyResources(this.pictureBox_framesShow, "pictureBox_framesShow");
            this.pictureBox_framesShow.Name = "pictureBox_framesShow";
            this.pictureBox_framesShow.TabStop = false;
            // 
            // BatSpasScreensaverForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pictureBox_framesShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BatSpasScreensaverForm";
            this.Load += new System.EventHandler(this.BatSpasScreensaverForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BatSpasScreensaverForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BatSpasScreensaverForm_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BatSpasScreensaverForm_MouseDoubleClick);
            this.MouseHover += new System.EventHandler(this.BatSpasScreensaverForm_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BatSpasScreensaverForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_framesShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_framesShow;
        private System.Windows.Forms.Timer timer_fps;
    }
}

