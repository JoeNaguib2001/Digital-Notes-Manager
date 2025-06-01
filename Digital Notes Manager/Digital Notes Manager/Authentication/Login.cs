using DevExpress.XtraEditors;
using Digital_Notes_Manager.Models;

namespace Digital_Notes_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            using (var context = new ManageNoteContext())
            {
                string enteredUsername = userNameTxt.Text;
                string enteredPassword = passwordTxt.Text;

                var user = context.Users.FirstOrDefault(u => u.Username == enteredUsername && u.Password == enteredPassword);

                if (user != null)
                {
                    Properties.Settings.Default.userID = user.UserID;

                    if (RememberMeCheckBox.Checked)
                    {
                        Properties.Settings.Default.rememberMe = true;
                        Properties.Settings.Default.userName = enteredUsername;
                    }
                    else
                    {
                        Properties.Settings.Default.rememberMe = false;
                        Properties.Settings.Default.userName = string.Empty;
                    }

                    Properties.Settings.Default.Save();

                    XtraMessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Main_Form mainForm = new Main_Form();
                    mainForm.FormClosed += (s, args) => Application.Exit();
                    mainForm.Show();
                    Utilities.LoginRegisterMDI.Hide();
                    userNameTxt.Clear();
                    passwordTxt.Clear();
                }
                else
                {
                    XtraMessageBox.Show("Wrong Username or Password");
                }
            }
        }
    }

}

