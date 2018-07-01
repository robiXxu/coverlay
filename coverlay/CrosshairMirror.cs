using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace coverlay {
    public partial class CrosshairMirror : Form {

        public enum GWL {
            ExStyle = -20
        }

        public enum WS_EX {
            Transparent = 0x20,
            Layered = 0x80000
        }

        public enum LWA {
            ColorKey = 0x1,
            Alpha = 0x2
        }

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte alpha, LWA dwFlags);

        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            int wl = GetWindowLong(this.Handle, GWL.ExStyle);
            wl = wl | 0x80000 | 0x20;
            SetWindowLong(this.Handle, GWL.ExStyle, wl);
            SetLayeredWindowAttributes(this.Handle, 0, 255, LWA.Alpha);
        }

        private coverlayTray parent = null;
        public Int32 captureSize = 64;
        public Int32 captureThreadSleep = 30;
        public Thread captureThread = null;

        public CrosshairMirror(coverlayTray _parent) {
            InitializeComponent();
            this.parent = _parent;
            //int initialStyle = GetWindowLong(this.Handle, -20);
            //SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
        }

        private void CrosshairMirror_Load(object sender, EventArgs e) {
            this.DesktopLocation = new Point(-240, 411);
            Screen screen = null;
            if (this.parent.crosshairForm != null || !this.parent.crosshairForm.IsDisposed || !this.parent.crosshairForm.Disposing) {
                screen = Screen.FromControl(this.parent.crosshairForm);
            } else {
                screen = Screen.PrimaryScreen;
            }
            CheckForIllegalCrossThreadCalls = false;
            this.captureThread = new Thread(() => this.CaptureCrosshair(this.parent));

            this.captureThread.Start();
        }

        private void CaptureCrosshair(coverlayTray _parent) {
            //int i = 0;
            while(true) {
                
                Bitmap bm = new Bitmap(captureSize, captureSize);

                Graphics g = Graphics.FromImage(bm);

                //Int32 y = (screen.Bounds.Height / 2);
                //Int32 x = (screen.Bounds.Width / 2);

                //Int32 y1 = (y - captureSize);
                //Int32 x1 = (x - captureSize);

                //Int32 y2 = (y + captureSize);
                //Int32 x2 = (x + captureSize);

                //g.CopyFromScreen(x1,y1,x2,y2,bm.Size);

                g.CopyFromScreen(parent.crosshairForm.Left + 35, parent.crosshairForm.Top-10, 0, 0, bm.Size);
                this.mirrorImage.Image = bm;

                //this.Text = "Capture Nr " + (i++);

                Thread.Sleep(this.captureThreadSleep);
            }
        }

        private void CrosshairMirror_FormClosing(object sender, FormClosingEventArgs e) {
            this.captureThread.Abort();
        }

        private void CrosshairMirror_Move(object sender, EventArgs e) {
            this.Text = this.DesktopLocation.ToString();
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                /* WS_EX_LAYERED |  WS_EX_TRANSPARENT */
                cp.ExStyle |= 0x80000;// | 0x20;
                return cp;
            }
        }


    }

}
