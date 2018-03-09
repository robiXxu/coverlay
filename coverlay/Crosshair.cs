using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coverlay {
    public partial class Crosshair : Form {
        public Crosshair() {
            InitializeComponent();
            Color transparentColor = Color.Black;
            this.TransparencyKey = transparentColor;
            this.BackColor = transparentColor;
        }

        private void Crosshair_Load( object sender, EventArgs e ) {
            try {
                this.Top = this.Top - Properties.Settings.Default.yindex;

            } catch (Exception) { }

            try {
                this.Opacity = Properties.Settings.Default.opacity;
            }catch{}
            if (Properties.Settings.Default.customCrosshair != "") {
                try {
                    this.crosshairBox.Image = new Bitmap(Properties.Settings.Default.customCrosshair);
                } catch (Exception) { }
            } else {
                this.crosshairBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(Properties.Settings.Default.crosshair);

            }
        }
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                /* WS_EX_LAYERED |  WS_EX_TRANSPARENT */ 
                cp.ExStyle |= 0x80000  | 0x20 ;
                return cp;
            }
        }
    }
}
