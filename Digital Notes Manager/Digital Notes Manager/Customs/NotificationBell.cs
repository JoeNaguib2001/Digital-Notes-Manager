using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Digital_Notes_Manager.Customs
{

    public class NotificationBell : Control
    {
        private List<string> notifications = new List<string>();
        public event EventHandler BellClicked;
        private int _notificationCount;

        public int NotificationCount
        {
            get => _notificationCount;
            set
            {
                _notificationCount = value;
                this.Invalidate(); 
            }
        }

        public void AddNotification(string message)
        {
            notifications.Add(message);
            NotificationCount++;

            this.Invalidate(); 
        }
        public void ResetCounter()
        {
            this.NotificationCount = -1;
      
            this.Invalidate();
        }
        public List<string> GetNotifications()
        {
            var result = new List<string>(notifications);
            this.Invalidate(); 
            return result;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            BellClicked?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (Properties.Resources.pngegg != null)
            {
                g.DrawImage(Properties.Resources.pngegg, 0, 0, 20,20); 
            }

            if (NotificationCount > 0)
            {
                g.FillEllipse(Brushes.Red, 20, 0, 16, 16);
                g.DrawString(NotificationCount.ToString(), new Font("Segoe UI", 8, FontStyle.Bold), Brushes.White, new PointF(22, 1));
            }
        }
    }
}


