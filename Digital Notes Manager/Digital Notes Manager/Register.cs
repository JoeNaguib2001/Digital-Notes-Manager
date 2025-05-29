using DevExpress.XtraBars.Ribbon;
using System.Drawing.Drawing2D;

namespace Digital_Notes_Manager
{
    public partial class Register : RibbonForm
    {
        public Register()
        {
            InitializeComponent();
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


        private void simpleButton1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void SinUpBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
