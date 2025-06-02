using DevExpress.XtraEditors;
using Digital_Notes_Manager.Models;

namespace Digital_Notes_Manager
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    GraphicsPath path = new GraphicsPath();
        //    int radius = 20; // adjust corner radius
        //    path.StartFigure();
        //    path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
        //    path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
        //    path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
        //    path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
        //    path.CloseFigure();
        //    this.Region = new Region(path);
        //}




        private void SinUpBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text.Trim();
            string password = passwordTxt.Text;
            string confirmPassword = passwordConfirmTxt.Text;


            if (string.IsNullOrWhiteSpace(username))
            {
                XtraMessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                XtraMessageBox.Show("Password is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                XtraMessageBox.Show("Please confirm your password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordConfirmTxt.Focus();
                return;
            }

            if (password.Length < 6)
            {
                XtraMessageBox.Show("Password must be at least 6 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTxt.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                XtraMessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordConfirmTxt.Focus();
                return;
            }

            using (var context = new ManageNoteContext())
            {

                bool userExists = context.Users.Any(u => u.Username == username);
                if (userExists)
                {
                    XtraMessageBox.Show("Username already exists. Choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newUser = new User
                {
                    Username = username,
                    Password = password
                };

                context.Users.Add(newUser);
                context.SaveChanges();

                Properties.Settings.Default.userID = newUser.UserID;
                Properties.Settings.Default.Save();

                XtraMessageBox.Show("Registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                usernameTxt.Text = "";
                passwordTxt.Text = "";
                passwordConfirmTxt.Text = "";
                if (RememberMeCheckBox.Checked)
                {
                    Properties.Settings.Default.rememberMe = true;
                    Properties.Settings.Default.userName = username;
                }
                else
                {
                    Properties.Settings.Default.rememberMe = false;
                    Properties.Settings.Default.userName = string.Empty;
                }

                Main_Form main_Form = new Main_Form();
                main_Form.Show();
                passwordConfirmTxt.Clear();
                passwordTxt.Clear();
                usernameTxt.Clear();
                main_Form.FormClosed += (s, args) =>
                {
                    Application.Exit();
                };
                Utilities.LoginRegisterMDI.Hide();
            }
        }
    }
}
