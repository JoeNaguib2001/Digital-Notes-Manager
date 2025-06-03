using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Digital_Notes_Manager
{
    public partial class NotificationPopupForm : Form
    {
        public NotificationPopupForm(List<string> messages)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.White;
            this.Size = new Size(300, 300); 
            this.TopMost = true;

           
           this.Location = new Point(1000, 100);

            this.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var path = RoundedRect(new Rectangle(0, 0, this.Width - 1, this.Height - 1), 10))
                using (var pen = new Pen(Color.LightGray, 2))
                {
                    g.DrawPath(pen, path);
                }
            };

            var closeButton = new Button
            {
                Text = "×",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Size = new Size(30, 30),
                Location = new Point(this.Width - 35, 5),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent
            };
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Click += (s, e) => this.Close();
            this.Controls.Add(closeButton);

            Panel containerPanel = new Panel
            {
                Location = new Point(10, 40),
                Size = new Size(this.Width - 20, this.Height - 50),
                AutoScroll = true,
                BackColor = Color.White
            };

            int y = 0;
            foreach (var msg in messages)
            {
                Panel card = new Panel
                {
                    Size = new Size(containerPanel.Width - 30, 60),
                    Location = new Point(0, y),
                    BackColor = Color.FromArgb(245, 245, 245),
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(8),
                    Tag = msg
                };

                PictureBox icon = new PictureBox
                {
                    Image = Properties.Resources.pngegg,
                    Size = new Size(24, 24),
                    Location = new Point(5, 5),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                Label label = new Label
                {
                    Text = msg,
                    Location = new Point(35, 8),
                    Size = new Size(card.Width - 20 - 30, 40),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = false
                };

                Button deleteButton = new Button
                {

                    Text = "x",
                    Font = new Font("Segoe UI",7, FontStyle.Bold),
                    Size = new Size(20, 20),
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.Red,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right

                };
                label.Size = new Size(card.Width - deleteButton.Width - 50, 40);
                deleteButton.Location = new Point(card.ClientSize.Width - deleteButton.Width - 8, 1);

                deleteButton.FlatAppearance.BorderSize = 0;

                deleteButton.Click += (s, e) =>
                {
                    containerPanel.Controls.Remove(card);
                    messages.Remove(msg);
                    RearrangeCards(containerPanel);
                };


                card.Controls.Add(icon);
                card.Controls.Add(label);
                card.Controls.Add(deleteButton);
                containerPanel.Controls.Add(card);
                y += 65;
            }

            this.Controls.Add(containerPanel);
        }
        private void RearrangeCards(Panel containerPanel)
        {
            int y = 0;
            foreach (Control ctrl in containerPanel.Controls)
            {
                ctrl.Location = new Point(0, y);
                y += 65;
            }
        }
        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
