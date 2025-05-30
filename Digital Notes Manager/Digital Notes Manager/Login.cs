using DevExpress.XtraEditors;
using Digital_Notes_Manager.Models;

namespace Digital_Notes_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            loginBtn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            loginBtn.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            using (var context = new ManageNoteContext())
            {
                string enteredUsername = userNameTxt.Text;
                string enteredPassword = passwordTxt.Text;

                var user = context.Users
                    .FirstOrDefault(u => u.Username == enteredUsername && u.Password == enteredPassword);

                if (user != null)
                {
                    Properties.Settings.Default.UserID = user.UserID;
                    Properties.Settings.Default.Save();

                    //XtraMessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Main_Form main = new Main_Form();
                    main.Show();
                    Utilities.LoginRegisterMDI.Hide();

                }
                else
                {
                    XtraMessageBox.Show("Wrong Username or Password");
                    return;
                }

            }
        }
    }
}
