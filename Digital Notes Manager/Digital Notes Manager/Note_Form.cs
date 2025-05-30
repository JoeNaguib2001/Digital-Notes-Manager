using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Digital_Notes_Manager.Models;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Digital_Notes_Manager
{
    public partial class Note_Form : RibbonForm
    {
        private BarManager barManager;
        private PopupMenu popupMenu;
        private readonly ManageNoteContext _ManageNoteContext = Utilities.manageNoteContext;
        public Note_Form()
        {
            InitializeComponent();
            stylePanal.Buttons.Clear();
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

            SetButtonAppearance();
            richTextBox1.Select();

            //drag drop the from from anu emty space
            MakeFormDraggable(this);

            PopMenu();


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
        private void StylePanal_ButtonChecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
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
            //MessageBox.Show(e.Button.ToString());
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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



        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void MakeFormDraggable(Control control)
        {
            control.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }
            };
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            //new 
            //popupMenu1.ShowPopup();
        }

        private void stylePanal_Click(object sender, EventArgs e)
        {

        }

        private void PopMenu()
        {

            barManager = new BarManager();
            barManager.Form = this;

            // Step 2: Create PopupMenu
            popupMenu = new PopupMenu(barManager);

            // Step 3: Add items
            BarButtonItem item1 = new BarButtonItem(barManager, "Set Notification");


            // Handle clicks
            item1.ItemClick += (s, e) => Calender.ShowPopup();

            // Add items to popup menu
            popupMenu.AddItem(item1);


            // Step 4: Attach to button click
            MenuBtn.Click += (s, e) =>
            {


                Point leftOfButton = MenuBtn.PointToScreen(new Point(-MenuBtn.Width * 2, 20)); // if Width unknown, estimate
                popupMenu.ShowPopup(leftOfButton);

                //popupMenu.ShowPopup(MousePosition); // show near cursor
            };
        }

        private void Close_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {

        }

        //private void Calender_Click(object sender, EventArgs e)
        //{
        //    Calender.ShowPopup();
        //}
        private void saveBtn_Click(object sender, EventArgs e)
        {
            Note newNote = new Note
            {
                Title = "132",
                Content = "123",
                CreationDate = DateTime.Now,
                ReminderDate = DateTime.Now,
                UserID = 1,
                Category = Category.Study,
            };
            _ManageNoteContext.Notes.Add(newNote);
            _ManageNoteContext.SaveChanges();
            Utilities.SetNotesGridControlDataSource();
        }
    }
}
