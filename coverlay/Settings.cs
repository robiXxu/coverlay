using MaterialSkin.Controls;
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
    public partial class Settings : MaterialForm {

        private coverlayTray parent = null;

        public Settings(coverlayTray _parent) {
            InitializeComponent();
            this.parent = _parent;
        }

        private void defaultCrosshair_Click(object sender, EventArgs e) {
            Properties.Settings.Default.crosshair = "__default.png";
            this.RefreshCrosshair();
        }

        private void RefreshCrosshair() {
            if (this.parent.crosshairForm != null) {
                this.parent.crosshairForm.Crosshair_Refresh();
            }
        }

        private void selectCustomCrosshair_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog res = new OpenFileDialog();
                res.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;...";
                if (res.ShowDialog() == DialogResult.OK) {
                    if (res.FileName != "") {
                        Properties.Settings.Default.crosshair = res.FileName;
                        Properties.Settings.Default.Save();
                        this.RefreshCrosshair();
                    }
                }
            } catch (Exception ex) {
                // add logs
            }
        }

        private void upButton_Click(object sender, EventArgs e) {
            //Properties.Settings.Default.Reload();
            //Int32 prevValue = Convert.ToInt32(Properties.Settings.Default.yindex);
            //Properties.Settings.Default.yindex = prevValue + Convert.ToInt32(pixelCount.Value);
            //Properties.Settings.Default.Save();
            //this.RefreshCrosshair();
        }

        private void downButton_Click(object sender, EventArgs e) {
            //Properties.Settings.Default.Reload();
            //Int32 prevValue = Convert.ToInt32(Properties.Settings.Default.yindex);
            //Properties.Settings.Default.yindex = prevValue + Convert.ToInt32(pixelCount.Value);
            //Properties.Settings.Default.Save();
            //this.RefreshCrosshair();
        }

        private void rightButton_Click(object sender, EventArgs e) {
            //Properties.Settings.Default.Reload();
            //Int32 prevValue = Convert.ToInt32(Properties.Settings.Default.zindex);
            //Properties.Settings.Default.zindex = prevValue - Convert.ToInt32(pixelCount.Value);
            //Properties.Settings.Default.Save();
            //this.RefreshCrosshair();
        }

        private void leftButton_Click(object sender, EventArgs e) {
            //Properties.Settings.Default.Reload();
            //Int32 prevValue = Convert.ToInt32(Properties.Settings.Default.yindex);
            //Properties.Settings.Default.zindex = prevValue + Convert.ToInt32(pixelCount.Value);
            //Properties.Settings.Default.Save();
            //this.RefreshCrosshair();
        }
    }
}
