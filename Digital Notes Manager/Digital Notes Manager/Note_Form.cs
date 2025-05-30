﻿using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Ribbon;
using Digital_Notes_Manager.AlarmSystem;
using Digital_Notes_Manager.Models;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Digital_Notes_Manager
{
    public enum Mode
    {
        Add,
        Edit
    }
    public partial class Note_Form : RibbonForm
    {

        public Mode Mode { get; set; }
        public int noteId { get; set; }

        private BarManager barManager;
        private PopupMenu popupMenu;
        private DateTimeOffset NotficationDate;

        public string _Title { get; set; }

        public string _Category { get; set; }

        private readonly ManageNoteContext _ManageNoteContext = Utilities.manageNoteContext;


        public Note_Form()
        {
            InitializeComponent();
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
            stylePanal.UseButtonBackgroundImages = false; // Removes circular borders
            stylePanal.ButtonInterval = 5; // Adjusts spacing between buttons

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

            TopPanal.BackColor = ColorTranslator.FromHtml("#2C3E50");
            TitleBox.BackColor = TopPanal.BackColor;
            Close_btn.Appearance.BackColor = Color.Tomato;

            MenuBtn.Appearance.BackColor = Color.LightGray;
            BellButton.Appearance.BackColor = Color.Orange;

            //GalleryItemGroup group = new GalleryItemGroup();
            //group.Items.Add(new GalleryItem(null, "", "", Color.Red));
            //group.Items.Add(new GalleryItem(null, "", "", Color.Green));
            //// Add more...

            //galleryControl1.Gallery.Groups.Add(group);
            //galleryControl1.Gallery.ItemClick += (s, e) =>
            //{
            //    var selectedColor = e.Item.HintColor; // Custom extension or mapping
            //};
        }
        public Note_Form(Digital_Notes_Manager.Models.Note note)
        {
            InitializeComponent();

            TitleBox.Text = note.Title;
            richTextBox1.Text = note.Content;
            Calender.EditValue = note.ReminderDate;
            Categorybox.Text = note.Category.ToString();

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }
        //change bell image
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



        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;





        private void Close_btn_Click(object sender, EventArgs e)
        {
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
            BarButtonItem item2 = new BarButtonItem(barManager, "change Color");

            // Handle clicks
            item1.ItemClick += (s, e) => Calender.ShowPopup();

            // Add items to popup menu
            popupMenu.AddItem(item1);
            popupMenu.AddItem(item2);
            // Step 4: Attach to button click
            MenuBtn.Click += (s, e) =>
            {


                Point leftOfButton = MenuBtn.PointToScreen(new Point(-MenuBtn.Width * 2, 20)); // if Width unknown, estimate
                popupMenu.ShowPopup(leftOfButton);

                //popupMenu.ShowPopup(MousePosition); // show near cursor
            };

        }



        //private void Calender_Click(object sender, EventArgs e)
        //{
        //    Calender.ShowPopup();
        //}
        private void saveBtn_Click(object sender, EventArgs e)
        {

            NotficationDate = new DateTimeOffset(NotficationDate.DateTime, TimeSpan.FromHours(+2));
            if (Mode == Mode.Add)
            {
                Digital_Notes_Manager.Models.Note newNote = new Digital_Notes_Manager.Models.Note
                {
                    Title = _Title,
                    Content = richTextBox1.Rtf,
                    CreationDate = DateTime.Now,
                    ReminderDate = NotficationDate.DateTime,
                    Category = (Category)Enum.Parse(typeof(Category), _Category),
                    UserID = Properties.Settings.Default.userID
                };

                _ManageNoteContext.Notes.Add(newNote);
                _ManageNoteContext.SaveChanges();
                Alarm.AddNewNoteToAlarmSystemNotesList(newNote);
                Utilities.SetNotesGridControlDataSource();
                Mode = Mode.Edit;
                noteId = newNote.ID;
                _ManageNoteContext.Notes.Entry(newNote).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }

            else if (Mode == Mode.Edit)
            {
                var currentNote = _ManageNoteContext.Notes.FirstOrDefault(n => n.ID == noteId);
                if (currentNote != null)
                {
                    currentNote.Title = _Title;
                    currentNote.Content = richTextBox1.Rtf;
                    currentNote.ReminderDate = NotficationDate.DateTime;
                    currentNote.Category = (Category)Enum.Parse(typeof(Category), _Category);
                    _ManageNoteContext.Notes.Entry(currentNote).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    _ManageNoteContext.SaveChanges();
                    Alarm.AddNewNoteToAlarmSystemNotesList(currentNote);
                    _ManageNoteContext.Entry(currentNote).State = Microsoft.EntityFrameworkCore.EntityState.Detached; // هنا بتعمل ديتاتش

                    Utilities.SetNotesGridControlDataSource();
                }

            }

        }

        private void Calender_EditValueChanged(object sender, EventArgs e)
        {
            if (Calender.DateTimeOffset > DateTimeOffset.Now)
            {
                NotficationDate = Calender.DateTimeOffset;
                ChangeBell();
            }
            else
            {
                MessageBox.Show("invalid");
            }
            //MessageBox.Show("Confirmed selection: " + NotficationDate.ToString());
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

        private void Categorybox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Category = Categorybox.Text;
            //Console.WriteLine("Changed to: " + selected);
        }

        private void TopPanal_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }

        }
    }
}
