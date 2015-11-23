using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coverlay {
    public partial class changeCrosshair : Form {
        coverlayform parent;
        int yindexcount;
        public changeCrosshair ( coverlayform _parent ) {
            InitializeComponent();
            this.parent = _parent;
        }

        private void nightvision_Load ( object sender, EventArgs e ) {
            try {
                this.trackBar1.Value = (int)(Properties.Settings.Default.opacity * 100);
                this.label2.Text = Convert.ToString(Properties.Settings.Default.opacity * 100);

                this.yindexcount = Properties.Settings.Default.yindex;

            } catch { }
            this.Top = this.Top + 150;
        }
      
        private void resetcustomCrosshairSetting () {
            Properties.Settings.Default.customCrosshair = "";
        }
        private void saveCrosshair (string id) {
            this.resetcustomCrosshairSetting();
            Properties.Settings.Default.crosshair = id;
            Properties.Settings.Default.Save();
        }

        private void pictureBox1_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c1;
            saveCrosshair("c1");
        }

        private void pictureBox2_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c2;
            saveCrosshair("c2");
        }

        private void pictureBox3_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c3black;
            saveCrosshair("c3black");
        }

        private void pictureBox4_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c4;
            saveCrosshair("c4");
        }

        private void pictureBox5_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c5;
            saveCrosshair("c5");
        }

        private void pictureBox6_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c6;
            saveCrosshair("c6");
        }

        private void pictureBox7_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c7;
            saveCrosshair("c7");
        }

        private void pictureBox8_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c8;
            saveCrosshair("c8");
        }

        private void pictureBox9_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c9;
            saveCrosshair("c9");
        }

        private void pictureBox10_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c10;
            saveCrosshair("c10");
        }

        private void pictureBox11_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c11;
            saveCrosshair("c11");
        }

        private void pictureBox12_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c12;
            saveCrosshair("c12");
        }

        private void pictureBox13_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c13;
            saveCrosshair("c13");
        }

        private void pictureBox14_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c14;
            saveCrosshair("c14");
        }

        private void pictureBox15_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c15;
            saveCrosshair("c15");
        }

        private void pictureBox16_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c16;
            saveCrosshair("c16");
        }

        private void pictureBox17_Click ( object sender, EventArgs e ) {
            this.parent.crosshair.Image = coverlay.Properties.Resources.c17;
            saveCrosshair("c17");
        }

        private void pictureBox18_Click ( object sender, EventArgs e ) {
            try {
                OpenFileDialog res = new OpenFileDialog();
                res.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;...";
                if (res.ShowDialog() == DialogResult.OK) {
                    if (res.FileName != "") {
                        this.parent.crosshair.Image = new Bitmap(res.FileName);
                        Properties.Settings.Default.customCrosshair = res.FileName;
                        Properties.Settings.Default.Save();
                    }
                }
            }catch(Exception ex){
            }
        }

        private void trackBar1_Scroll ( object sender, EventArgs e ) {
            Properties.Settings.Default.opacity = this.parent.Opacity = ((double)trackBar1.Value / (double)100);
            this.label2.Text = this.trackBar1.Value.ToString() + "%";

            
            Properties.Settings.Default.Save();
        }

        private void pictureBox20_Click ( object sender, EventArgs e ) {
            yindexcount--;
            this.parent.Top--;
            Properties.Settings.Default.yindex = yindexcount;
            Properties.Settings.Default.Save();
        }
    }
}
