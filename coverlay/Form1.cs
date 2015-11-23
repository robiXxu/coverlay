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
    public partial class coverlayform : Form {
        public coverlayform () {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            
        }

        private void Form1_Load ( object sender, EventArgs e ) {
            //this.Top = this.Top - 10;
            //this.IsMdiContainer = true;
            try {
                this.Top = this.Top - Properties.Settings.Default.yindex;
                //this.Left = this.Left - Convert.ToInt32(Properties.Settings.Default.xindex);

            } catch (Exception) { }

            try {
                this.Opacity = Properties.Settings.Default.opacity;
            }catch{}
            if (Properties.Settings.Default.customCrosshair != "") {
                try {

                    this.crosshair.Image = new Bitmap(Properties.Settings.Default.customCrosshair);
                } catch (Exception) { }
            } else {
                this.crosshair.Image = (Image)Properties.Resources.ResourceManager.GetObject(Properties.Settings.Default.crosshair);

            }
        }
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                // Set the form click-through
                cp.ExStyle |= 0x80000 /* WS_EX_LAYERED */ | 0x20 /* WS_EX_TRANSPARENT */;
                return cp;
            }
        }
        

        private void coverlayform_KeyDown ( object sender, KeyEventArgs e ) {
            if (e.KeyCode == Keys.N && e.Control) {
                changeCrosshair nv = new changeCrosshair(this);
            
                nv.Show();
            }
        }
    }
}
