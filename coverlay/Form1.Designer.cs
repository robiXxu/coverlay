namespace coverlay {
    partial class coverlayform {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coverlayform));
            this.crosshair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.crosshair)).BeginInit();
            this.SuspendLayout();
            // 
            // crosshair
            // 
            this.crosshair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crosshair.Location = new System.Drawing.Point(0, 0);
            this.crosshair.Name = "crosshair";
            this.crosshair.Size = new System.Drawing.Size(32, 32);
            this.crosshair.TabIndex = 0;
            this.crosshair.TabStop = false;
            // 
            // coverlayform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(32, 32);
            this.ControlBox = false;
            this.Controls.Add(this.crosshair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "coverlayform";
            this.Opacity = 0.4D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crosshair Overlay - by robiXxu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coverlayform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.crosshair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox crosshair;

    }
}

