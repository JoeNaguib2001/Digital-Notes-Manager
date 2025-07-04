﻿using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Ribbon;
using Digital_Notes_Manager.AlarmSystem;
using Digital_Notes_Manager.Models;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Digital_Notes_Manager
{

    public partial class Note_Form : RibbonForm
    {


        public int noteId { get; set; }

        private BarManager barManager;
        private PopupMenu popupMenu;
        private DateTimeOffset NotficationDate;

        public string _Title { get; set; }

        public string _Category { get; set; }

        private readonly ManageNoteContext _ManageNoteContext = Utilities.manageNoteContext;
        public Note CurrentNote { get; set; }
        private Note ToDeleteNote;

        private bool Completed;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private string currentCalendarContext = ""; // Could be "Notification", "Start", "End"
        private DateTime StartDate;
        private DateTime EndDate;

        public Note_Form()
        {
            InitializeComponent();
            Categorybox.SelectedIndexChanged -= Categorybox_SelectedIndexChanged;
            SetupNoteForm();

            CreateNote();
            Categorybox.SelectedIndexChanged += Categorybox_SelectedIndexChanged;

        }
        public Note_Form(Note note)
        {
            InitializeComponent();
            _Category = note.Category.ToString();
            CurrentNote = note;
            Categorybox.SelectedIndexChanged -= Categorybox_SelectedIndexChanged;
            SetupNoteForm();

            TitleBox.Text = note.Title;
            RichTextBox rt = new RichTextBox();
            rt.Rtf = note.Content;
            richTextBox1.Rtf = rt.Rtf;
            NotficationDate = new DateTimeOffset(note.ReminderDate, TimeSpan.FromHours(0));
            Categorybox.Text = note.Category.ToString();
            Categorybox.SelectedIndexChanged += Categorybox_SelectedIndexChanged;
            if (note.ReminderDate < DateTime.Now && note.IsCompleted == true)
            {
                IsCompleted.Visible = true;
                IsCompleted.Text = "Completed";
                IsCompleted.Checked = true;
            }
            else if (note.ReminderDate < DateTime.Now && note.IsCompleted == false)
            {
                IsCompleted.Visible = true;
                IsCompleted.Text = "Not Completed";
                IsCompleted.Checked = false;
            }

            saveBtn.ImageOptions.Image = Properties.Resources.disk2;
        }

        private void SetupNoteForm()
        {
            stylePanal.Buttons.Clear();
            _Title = TitleBox.Text;
            WindowsUIButton btn1 = new WindowsUIButton("", ButtonStyle.CheckButton);
            WindowsUIButton btn2 = new WindowsUIButton("", ButtonStyle.CheckButton);
            WindowsUIButton btn3 = new WindowsUIButton("", ButtonStyle.CheckButton);

            btn1.ImageUri = "Bold;Size16x16";
            btn2.ImageUri = "Italic;Size16x16";
            btn3.ImageUri = "Underline;Size16x16";
            btn1.Checked = false;
            btn2.Checked = false;
            btn3.Checked = false;

            stylePanal.Buttons.AddRange(new WindowsUIButton[] { btn1, btn2, btn3 });
            stylePanal.UseButtonBackgroundImages = false;
            stylePanal.ButtonInterval = 5;

            richTextBox1.BackColor = this.BackColor;
            richTextBox1.ForeColor = this.ForeColor;

            SetButtonAppearance();
            richTextBox1.Select();



            //pop the menu for notification
            PopMenu();

            //load category
            GetCategory();
            Categorybox.SelectedIndex = 0;

            //check notfication
            ChangeBell();

            //TopPanal.BackColor = ColorTranslator.FromHtml("#2C3E50");
            TitleBox.BackColor = TopPanal.BackColor;
            Close_btn.Appearance.BackColor = Color.Tomato;

            MenuBtn.Appearance.BackColor = Color.LightGray;
            BellButton.Appearance.BackColor = Color.Orange;
        }
        //change bell image
        private void CreateNote()
        {

            Digital_Notes_Manager.Models.Note newNote = new Digital_Notes_Manager.Models.Note
            {
                Title = _Title,
                Content = richTextBox1.Rtf,
                CreationDate = DateTime.Now,
                ReminderDate = NotficationDate.DateTime,
                Category = (Category)Enum.Parse(typeof(Category), Categorybox.Text),
                UserID = Properties.Settings.Default.userID
            };

            _ManageNoteContext.Notes.Add(newNote);
            _ManageNoteContext.SaveChanges();
            ToDeleteNote = newNote;
            Alarm.AddNewNoteToAlarmSystemNotesList(newNote);
            Utilities.SetNotesGridControlDataSource();

            noteId = newNote.ID;
            _ManageNoteContext.Notes.Entry(newNote).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }

        public void ChangeBell()
        {
            if (NotficationDate > DateTime.Now)
                BellButton.ImageOptions.Image = Properties.Resources.bell2;
        }
        private void SetTextStyle()
        {
            FontStyle style = FontStyle.Regular;

            // Check each button and add styles accordingly
            foreach (WindowsUIButton button in stylePanal.Buttons.OfType<WindowsUIButton>())
            {
                if (button.Checked)
                {
                    if (button.ImageUri.StartsWith("Bold"))
                        style |= FontStyle.Bold;
                    else if (button.ImageUri.StartsWith("Italic"))
                        style |= FontStyle.Italic;
                    else if (button.ImageUri.StartsWith("Underline"))
                        style |= FontStyle.Underline;
                }
            }

            // Apply style to selected text or whole text
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont ?? richTextBox1.Font, style);
            }
            else
            {
                // Apply to entire text or set default font style (optional)
                richTextBox1.Font = new Font(richTextBox1.Font, style);
            }
        }
        private void StylePanal_ButtonChecked(object sender, ButtonEventArgs e)
        {

            var clickedBtn = e.Button as WindowsUIButton;

            if (clickedBtn != null)
            {
                // Toggle the checked state manually
                clickedBtn.Checked = true;

            }

            SetButtonAppearance();
            SetTextStyle();


        }


        private void SetButtonAppearance()
        {
            foreach (WindowsUIButton button in stylePanal.Buttons.OfType<WindowsUIButton>())
            {
                button.Appearance.BackColor = button.Checked ? Color.Black : Color.BlueViolet;
                button.Appearance.Options.UseBackColor = true;
            }
        }

        private void stylePanal_ButtonUnchecked(object sender, ButtonEventArgs e)
        {

            SetTextStyle();

        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // adjust corner radius

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }


        private void GetCategory()
        {

            var Categories = Enum.GetNames(typeof(Category));
            Categorybox.Properties.Items.AddRange(Categories);

        }









        private void Close_btn_Click(object sender, EventArgs e)
        {
            Container.Visible = false;
            this.Close();
        }




        private void PopMenu()
        {

            barManager = new BarManager();
            barManager.Form = this;

            // Step 2: Create PopupMenu
            popupMenu = new PopupMenu(barManager);

            // Step 3: Add items
            BarButtonItem item1 = new BarButtonItem(barManager, "Set Notification");
            BarButtonItem item2 = new BarButtonItem(barManager, "Set Start");
            BarButtonItem item3 = new BarButtonItem(barManager, "Set  End");


            // Handle clicks
            item1.ItemClick += (s, e) =>
            {
                currentCalendarContext = "Notification";
                Calender.ShowPopup();
            };

            item2.ItemClick += (s, e) =>
            {
                currentCalendarContext = "Start";
                Calender.ShowPopup();
            };

            item3.ItemClick += (s, e) =>
            {
                currentCalendarContext = "End";
                Calender.ShowPopup();
            };


            // Add items to popup menu
            popupMenu.AddItem(item1);
            popupMenu.AddItem(item2);
            popupMenu.AddItem(item3);

            // Step 4: Attach to button click
            MenuBtn.Click += (s, e) =>
            {


                Point leftOfButton = MenuBtn.PointToScreen(new Point(-MenuBtn.Width * 2, 20)); // if Width unknown, estimate
                popupMenu.ShowPopup(leftOfButton);


            };

        }




        private void saveBtn_Click(object sender, EventArgs e)
        {

            var currentNote = _ManageNoteContext.Notes.FirstOrDefault(n => n.ID == noteId);
            if (currentNote != null)
            {
                currentNote.Title = _Title;
                currentNote.Content = richTextBox1.Rtf;
                currentNote.ReminderDate = NotficationDate.DateTime;
                currentNote.Category = (Category)Enum.Parse(typeof(Category), Categorybox.Text);
                currentNote.IsCompleted = Completed;
                currentNote.StartDate = StartDate;
                currentNote.EndDate = EndDate;
                _ManageNoteContext.Notes.Entry(currentNote).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _ManageNoteContext.SaveChanges();
                Alarm.AddNewNoteToAlarmSystemNotesList(currentNote);
                _ManageNoteContext.Entry(currentNote).State = Microsoft.EntityFrameworkCore.EntityState.Detached; // هنا بتعمل ديتاتش

                Utilities.SetNotesGridControlDataSource();
                Utilities.ViewNotesDashboard.RefreshPoppedOutNotes();
            }

            saveBtn.ImageOptions.Image = Properties.Resources.disk2;
        }



        private void Calender_EditValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Calender.DateTimeOffset.DateTime;

            if (currentCalendarContext == "Notification")
            {
                NotficationDate = Calender.DateTimeOffset;
                if (selectedDate > DateTime.Now)
                {
                    ChangeBell();
                }
            }
            else if (currentCalendarContext == "Start")
            {
                var x = Calender.DateTimeOffset;
                StartDate = x.DateTime;

            }
            else if (currentCalendarContext == "End")
            {
                var x = Calender.DateTimeOffset;
                EndDate = x.DateTime;
            }

            saveBtn.ImageOptions.Image = Properties.Resources.disk1;

        }

        private void TitleBox_DoubleClick(object sender, EventArgs e)
        {
            TitleBox.Properties.ReadOnly = false;
            TitleBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TitleBox.Focus();
            TitleBox.SelectAll();
        }

        private void TitleBox_Leave(object sender, EventArgs e)
        {
            TitleBox.Properties.ReadOnly = true;
            TitleBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            _Title = TitleBox.Text;
        }

        private void TitleBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Move focus to the form or another control
                _Title = TitleBox.Text;
                richTextBox1.Focus();

            }
        }

        public void Categorybox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Category = Categorybox.Text;
            ToastForm.ShowToast($"Category Changed To {Categorybox.Text}", 3000);
            saveBtn.ImageOptions.Image = Properties.Resources.disk1;

        }

        private void TopPanal_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }

        }

        private void Note_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilities.OpenedNotes.Remove(CurrentNote);
        }

        private void Container_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20; // Radius of the curve

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle bounds = Container.ClientRectangle;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90); // Top-left
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90); // Top-right
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90); // Bottom-right
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90); // Bottom-left
            path.CloseFigure();

            Container.Region = new Region(path);
        }

        private void TopPanal_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle bounds = TopPanal.ClientRectangle;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90); // Top-left
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90); // Top-right
            path.AddLine(bounds.Right, bounds.Bottom, bounds.X, bounds.Bottom); // Straight bottom
            path.CloseFigure();

            TopPanal.Region = new Region(path);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (ToDeleteNote != null)
            {
                _ManageNoteContext.Remove(ToDeleteNote);
            }
            else
            {
                var StoredNote = _ManageNoteContext.Notes.FirstOrDefault(n => n.ID == CurrentNote.ID);
                if (StoredNote != null)
                {

                    _ManageNoteContext.Remove(StoredNote);
                }
            }
            _ManageNoteContext.SaveChanges();
            Utilities.SetNotesGridControlDataSource();
            TrashBtn.ImageOptions.Image = Properties.Resources.trash2;
            if (Utilities.ViewNotesDashboard != null)
            {
                Utilities.ViewNotesDashboard.RefreshPoppedOutNotes();
            }
            this.Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            saveBtn.ImageOptions.Image = Properties.Resources.disk1;
        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {
            saveBtn.ImageOptions.Image = Properties.Resources.disk1;
        }

        private void IsCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (IsCompleted.Checked)
            {
                IsCompleted.Text = "Completed";
                Completed = true;
            }
            else
            {
                IsCompleted.Text = "Not Completed";
                Completed = false;
            }
            saveBtn.ImageOptions.Image = Properties.Resources.disk1;
        }

    }
}
