using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using System.Drawing.Drawing2D;

namespace Digital_Notes_Manager
{
    public partial class Note : XtraForm
    {
        public Note()
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
            //MessageBox.Show(e.Button.ToString());

        }


        private void SetButtonAppearance()
        {
            foreach (WindowsUIButton button in stylePanal.Buttons.OfType<WindowsUIButton>())
            {
                button.Appearance.BackColor = button.Checked ? Color.Blue : Color.Black;
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


    }
}
