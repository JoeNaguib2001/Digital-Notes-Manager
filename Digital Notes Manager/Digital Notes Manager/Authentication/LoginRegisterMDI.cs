using Digital_Notes_Manager.Models;

namespace Digital_Notes_Manager
{
    public partial class LoginRegisterMDI : Form
    {
        Login login;
        Register register;

        public LoginRegisterMDI()
        {
            InitializeComponent();
            Utilities.LoginRegisterMDI = this;
            if (Utilities.RememberMe())
                AutoLogin();
            else
                LoadLogin();
        }
        private void AutoLogin()
        {
            using (var context = new ManageNoteContext())
            {
                var userName = Properties.Settings.Default.userName;
                var user = context.Users.FirstOrDefault(u => u.Username == userName);

                if (user != null)
                {
                    Properties.Settings.Default.userID = user.UserID;
                    Properties.Settings.Default.Save();

                    Main_Form mainForm = new Main_Form();
                    mainForm.FormClosed += (s, args) => Application.Exit();
                    mainForm.Shown += (s, e) => this.Hide();
                    mainForm.Show();
                }
                else
                {
                    LoadLogin();
                }
            }
        }

        private void LoadRegister()
        {
            if (register is null || register.IsDisposed)
            {
                register = new Register();
                register.TopLevel = false;
                register.FormBorderStyle = FormBorderStyle.None;
                register.Dock = DockStyle.Fill;
            }

            register.usernameTxt.Clear();
            register.passwordTxt.Clear();
            register.passwordConfirmTxt.Clear();
            loginRegisterMDIPanel.Controls.Clear();
            loginRegisterMDIPanel.Controls.Add(register);
            register.Show();
        }
        public void LoadLogin()
        {
            if (login is null || login.IsDisposed)
            {
                login = new Login();
                login.TopLevel = false;
                login.FormBorderStyle = FormBorderStyle.None;
                login.Dock = DockStyle.Fill;
            }
            login.userNameTxt.Clear();
            login.passwordTxt.Clear();
            loginRegisterMDIPanel.Controls.Clear();
            loginRegisterMDIPanel.Controls.Add(login);
            login.Show();
        }

        private void loginBtnFromMDI_Click(object sender, EventArgs e)
        {
            LoadLogin();
        }

        private void registerBtnFromMDI_Click(object sender, EventArgs e)
        {
            LoadRegister();
        }


    }
}
