namespace Digital_Notes_Manager
{
    public partial class Testing : Form
    {

        string Richfile;
        public Testing()
        {
            InitializeComponent();
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Richfile = richTextBox1.Rtf;

            richTextBox2.Rtf = Richfile;
        }
    }
}
