namespace coverlay {
    partial class CrosshairMirror {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mirrorImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mirrorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mirrorImage
            // 
            this.mirrorImage.BackColor = System.Drawing.SystemColors.ControlText;
            this.mirrorImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mirrorImage.Location = new System.Drawing.Point(0, 0);
            this.mirrorImage.Name = "mirrorImage";
            this.mirrorImage.Size = new System.Drawing.Size(240, 217);
            this.mirrorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mirrorImage.TabIndex = 0;
            this.mirrorImage.TabStop = false;
            // 
            // CrosshairMirror
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 217);
            this.Controls.Add(this.mirrorImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrosshairMirror";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrosshairMirror";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrosshairMirror_FormClosing);
            this.Load += new System.EventHandler(this.CrosshairMirror_Load);
            this.Move += new System.EventHandler(this.CrosshairMirror_Move);
            ((System.ComponentModel.ISupportInitialize)(this.mirrorImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox mirrorImage;
    }
}