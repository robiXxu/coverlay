using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coverlay {
    public class coverlayTray : Form {
        [STAThread]
        public static void Main() {
            Application.Run(new coverlayTray());
        }

        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private Settings settingsForm = null;
        private Crosshair crosshairForm = null;
        private Boolean crosshairVisible = true;

        public coverlayTray() {
            this.trayMenu = new ContextMenu();

            this.trayMenu.MenuItems.Add((this.crosshairVisible ? "Hide" : "Show"), toggleCrosshair);
            this.trayMenu.MenuItems.Add("Settings", onSettings);
            this.trayMenu.MenuItems.Add("Exit", onExit);
            
            this.trayIcon = new NotifyIcon();
            this.trayIcon.Text = "Crosshair Overlay";
            this.trayIcon.Icon = new Icon(SystemIcons.WinLogo, 64, 64);

            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;

            this.toggleCrosshairForm();
        }

        protected override void OnLoad(EventArgs e) {
            Visible = false;
            ShowInTaskbar = false;

            base.OnLoad(e);
        }

        private void toggleCrosshairForm() {
            if (this.crosshairForm == null || this.crosshairForm.IsDisposed || this.crosshairForm.Disposing) {
                this.crosshairForm = new Crosshair();
            }
            this.crosshairForm.Show();
            this.crosshairForm.Visible = this.crosshairVisible;
        }

        private void toggleCrosshair(object sender, EventArgs e) {
            this.crosshairVisible = !this.crosshairVisible;
            this.trayMenu.MenuItems[0].Text = (this.crosshairVisible ? "Hide" : "Show");
            this.toggleCrosshairForm();
        }

        private void onSettings(object sender, EventArgs e) {
            // Have only one instance of the Settings at the time. :) 
            if (this.settingsForm == null || this.settingsForm.IsDisposed || this.settingsForm.Disposing) {
                this.settingsForm = new Settings();
            }
            this.settingsForm.Show();
        }

        private void onExit(object sender, EventArgs e) {
            Application.Exit();
        }

        protected override void Dispose(bool isDisposing) {
            if (isDisposing) {
                trayIcon.Dispose();
            }
            base.Dispose(isDisposing);
        }

        private void InitializeComponent() {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(120, 70);
            this.Name = "coverlayTray";
            this.ResumeLayout(false);

        }
    }
}
