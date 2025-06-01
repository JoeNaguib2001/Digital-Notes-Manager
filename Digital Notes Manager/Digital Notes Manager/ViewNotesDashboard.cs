using DevExpress.Utils.Html.Internal;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Digital_Notes_Manager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Digital_Notes_Manager.Customs;
using System.Drawing.Drawing2D;
using DevExpress.XtraRichEdit.Model;


namespace Test
{
    public partial class ViewNotesDashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        private ManageNoteContext _dbContext;

        public ViewNotesDashboard()
        {
            InitializeComponent();
            LoadCategories();
        }


        private void LoadCategories()
        {
            FlowLayoutPanel CategoryflowLayoutPanel = new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(10),
            };


            CategoryPanel.Controls.Add(CategoryflowLayoutPanel);

            try
            {
                _dbContext = new ManageNoteContext();
                // جلب الفئات من قاعدة البيانات
                foreach (var category in Enum.GetNames(typeof(Category))) {

                    Panel card = CreateCategoryCard(category);
                    CategoryflowLayoutPanel.Controls.Add(card);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error on load Categories: {ex.Message}");
            }
        }

        private Panel CreateCategoryCard(string category)
        {
            RoundedPanel card = new RoundedPanel
            {
                Size = new Size(250, 200),
                AutoScroll = true,
                BackColor = Color.FromArgb(245, 245, 255), // لون مودرن – خلفية ناعمة
                Padding = new Padding(10),
                Margin = new Padding(15), // مسافة بين البطاقات
                BorderRadius = 20,
                BorderColor = Color.FromArgb(180, 180, 200), // لون حواف أنيق
                BorderThickness = 2
            };

            // إضافة Label لعنوان الملاحظة
            Label titleLabel = new Label
            {
                Text = category,
                Font = new Font("Tahoma", 16, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };
            card.Controls.Add(titleLabel);


            Category parsedCategory;
            if (Enum.TryParse(category, out parsedCategory))
            {
                int noteCount = _dbContext.Notes.Count(n => n.UserID == 1 && n.Category == parsedCategory);

                Label countLabel = new Label
                {
                    Text = $"Notes Count: {noteCount}",
                    Font = new Font("Tahoma", 10),
                    Location = new Point(10, 50),
                    AutoSize = true
                };
                card.Controls.Add(countLabel);
                card.BackColor = GetRandomPastelColor();

                // إضافة حدث النقر لعرض الملاحظات الخاصة بالفئة
                card.Click += (s, e) =>
                {
                    FlowLayoutPanel notesPanel = new FlowLayoutPanel
                    {
                        Dock = DockStyle.Fill,
                        AutoScroll = true,
                        FlowDirection = FlowDirection.LeftToRight,
                        WrapContents = true,
                        Padding = new Padding(10)
                    };

                    NotesPanel.Controls.Clear();
                    NotesPanel.Controls.Add(notesPanel);

                    var notes = _dbContext.Notes
                        .Where(n => n.Category == parsedCategory && n.UserID == 1)
                        .ToList();

                    foreach (var note in notes)
                    {
                        Panel noteCard = CreateNoteCard(note);
                        notesPanel.Controls.Add(noteCard);
                    }
                };
            }
            return card;

        }

        private Panel CreateNoteCard(Digital_Notes_Manager.Models.Note note)
        {
            // إنشاء Panel لتمثيل بطاقة الملاحظة
            RoundedPanel card = new RoundedPanel
            {
                Size = new Size(300, 250),
                AutoScroll = true,
                BackColor = Color.FromArgb(245, 245, 255), // لون مودرن – خلفية ناعمة
                Padding = new Padding(10),
                Margin = new Padding(15), // مسافة بين البطاقات
                BorderRadius = 20,
                BorderColor = Color.FromArgb(180, 180, 200), // لون حواف أنيق
                BorderThickness = 1
            };
            card.BackColor = GetRandomPastelColor();

            // إضافة Label لعنوان الملاحظة
            Label titleLabel = new Label
            {
                Text = note.Title,
                Font = new Font("Tahoma", 14, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };
            card.Controls.Add(titleLabel);

            Label line = new Label
            {
                Text = "------------------------------------",
                Font = new Font("Tahoma", 8, FontStyle.Bold),
                Location = new Point(10, 35),
                AutoSize = true
            };
            card.Controls.Add(line);


            // إضافة Label لاسم الفئة
            Label categoryLabel = new Label
            {
                Text = $"Category: {note.Category.ToString() ?? "UnCategorized"}",
                Font = new Font("Tahoma", 10, FontStyle.Italic),
                Location = new Point(10, 55),
                AutoSize = true
            };
            card.Controls.Add(categoryLabel);

            // إضافة Label لمحتوى الملاحظة
            Label contentLabel = new Label
            {
                Text = note.Content.Length > 80 ? note.Content.Substring(0, 80) + "..." : note.Content,
                Font = new Font("Tahoma", 12, FontStyle.Bold),
                Location = new Point(10, 80),
                Size = new Size(230, 60),
                AutoSize = false
            };
            card.Controls.Add(contentLabel);

            // إضافة Label لتاريخ التذكير
            Label reminderLabel = new Label
            {
                Text = $"Reminder Date: {note.ReminderDate:dd/MM/yyyy}",
                Font = new Font("Tahoma", 10, FontStyle.Bold),
                Location = new Point(10, 150),
                AutoSize = true
            };
            card.Controls.Add(reminderLabel);


            SimpleButton editButton = new SimpleButton
            {
                Text = "Edit",
                Location = new Point(50, 200),
                Size = new Size(80, 30),
                Appearance =
                            {
                                BackColor = Color.FromArgb(33, 150, 243), // أحمر ماتيريال
                                Font = new Font("Tahoma", 9F, FontStyle.Bold),
                                ForeColor = Color.White
                            },
                LookAndFeel =
                            {
                                UseDefaultLookAndFeel = false,
                                Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
                            },
                BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            };

            // تمكين الخصائص
            editButton.Appearance.Options.UseBackColor = true;
            editButton.Appearance.Options.UseForeColor = true;
            editButton.Appearance.Options.UseFont = true;

            // إضافة الرادياس
            editButton.Paint += (s, e) =>
            {
                var btn = s as SimpleButton;
                btn.Region = new Region(GetRoundedRectanglePath(btn.ClientRectangle, 10)); // Radius = 10
            };

            editButton.Click += (s, e) =>
            {
                MessageBox.Show($"Edit Note: {note.Title}");
                // يمكنك فتح نموذج لتعديل الملاحظة هنا
            };

            card.Controls.Add(editButton);

            // زرار Delete مودرن
            SimpleButton deleteButton = new SimpleButton
            {
                Text = "Delete",
                Location = new Point(170, 200),
                Size = new Size(80, 30),
                Appearance =
                            {
                                BackColor = Color.FromArgb(244, 67, 54), // أحمر ماتيريال
                                Font = new Font("Tahoma", 9F, FontStyle.Bold),
                                ForeColor = Color.White
                            },
                LookAndFeel =
                            {
                                UseDefaultLookAndFeel = false,
                                Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
                            },
                BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            };

            // تمكين الخصائص
            deleteButton.Appearance.Options.UseBackColor = true;
            deleteButton.Appearance.Options.UseForeColor = true;
            deleteButton.Appearance.Options.UseFont = true;

            // إضافة الرادياس
            deleteButton.Paint += (s, e) =>
            {
                var btn = s as SimpleButton;
                btn.Region = new Region(GetRoundedRectanglePath(btn.ClientRectangle, 10)); // Radius = 10
            };


            deleteButton.Click += (s, e) =>
            {
                if (MessageBox.Show($"Are you Sure to Delete This Note: {note.Title}؟", "Yes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _dbContext = new ManageNoteContext();
                    _dbContext.Notes.Remove(note);
                    _dbContext.SaveChanges();
                    CategoryPanel.Controls.Clear();
                    NotesPanel.Controls.Clear();
                    LoadCategories(); // إعادة تحميل الفئات والملاحظات
                }
            };
            card.Controls.Add(deleteButton);

            // إضافة حدث النقر على البطاقة
            card.Click += (s, e) => MessageBox.Show($"Title: {note.Title}\nContent: {note.Content}\nCategory: {note.Category.ToString()}\nReminder Date: {note.ReminderDate:dd/MM/yyyy}");

            return card;
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int r = radius;
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }
        private Color GetRandomPastelColor()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int red = (rand.Next(128) + 127);  // 127-255
            int green = (rand.Next(128) + 127);
            int blue = (rand.Next(128) + 127);
            return Color.FromArgb(red, green, blue);
        }
       
    }
}
