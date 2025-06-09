using System.Drawing.Drawing2D;
using Timer = System.Windows.Forms.Timer;

namespace Digital_Notes_Manager
{
    public partial class ToastForm : Form
    {
        private Label lblMessage;
        private Timer timer;

        public ToastForm(string message, int duration = 3000)
        {
            // Basic form setup
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.FromArgb(50, 50, 50);
            this.ForeColor = Color.White;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.Size = new Size(300, 50);

            // Label setup
            lblMessage = new Label()
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Padding = new Padding(10),
                Font = new Font("Segoe UI", 10)
            };

            this.Controls.Add(lblMessage);

            // Rounded corners
            this.Load += (s, e) => ApplyRoundedCorners(20);

            // Position bottom-right of screen
            this.Load += (s, e) =>
            {
                var screen = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(screen.Right - this.Width - 20, screen.Bottom - this.Height - 40);
            };

            // Timer setup
            timer = new Timer();
            timer.Interval = duration;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                this.Close();
            };
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            timer.Start();
        }

        private void ApplyRoundedCorners(int radius)
        {
            var bounds = new Rectangle(0, 0, this.Width, this.Height);
            var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }

        // Static method to show message
        public static void ShowToast(string message, int duration = 3000)
        {
            ToastForm toast = new ToastForm(message, duration);
            toast.Show();
        }
    }
}
