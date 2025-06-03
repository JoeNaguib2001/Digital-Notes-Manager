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

        public int NotificationCount => notifications.Count;

        public void AddNotification(string message)
        {
            notifications.Add(message);
            this.Invalidate(); // يعيد رسم العنصر
        }

        public List<string> GetNotifications()
        {
            var result = new List<string>(notifications);
            this.Invalidate(); // يخفي العدد
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

            // ارسم صورة الجرس
            if (Properties.Resources.bell2 != null)
            {
                g.DrawImage(Properties.Resources.bell2, 0, 0, 20,20); // حجم الجرس
            }

            // عدد الإشعارات (badge)
            if (notifications.Count > 0)
            {
                g.FillEllipse(Brushes.Red, 20, 0, 16, 16);
                g.DrawString(notifications.Count.ToString(), new Font("Segoe UI", 8, FontStyle.Bold), Brushes.White, new PointF(22, 1));
            }
        }
    }
}


