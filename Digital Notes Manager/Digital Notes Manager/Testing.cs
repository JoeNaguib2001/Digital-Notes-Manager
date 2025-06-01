namespace Digital_Notes_Manager
{
    public partial class Testing : Form
    {

        public Testing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel p = new Panel();
            p.Size = new Size(100, 100);
            p.BackColor = Color.Red;
            flowLayoutPanel1.Controls.Add(p);
        }
    }
}
