namespace coverlay {
    partial class Crosshair {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
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
        private void InitializeComponent () {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crosshair));
            this.crosshairBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.crosshairBox)).BeginInit();
            this.SuspendLayout();
            // 
            // crosshairBox
            // 
            this.crosshairBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crosshairBox.Location = new System.Drawing.Point(0, 0);
            this.crosshairBox.Name = "crosshair";
            this.crosshairBox.Size = new System.Drawing.Size(32, 32);
            this.crosshairBox.TabIndex = 0;
            this.crosshairBox.TabStop = false;
            // 
            // CrosshairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(32, 32);
            this.ControlBox = false;
            this.Controls.Add(this.crosshairBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crosshair";
            this.Opacity = 0.4D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crosshair Overlay - by robiXxu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Crosshair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crosshairBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox crosshairBox;

    }
}

