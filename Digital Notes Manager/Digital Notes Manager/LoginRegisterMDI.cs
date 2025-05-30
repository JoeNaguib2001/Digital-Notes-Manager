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
            LoadLogin();
        }
        private void LoadRegister()
        {
            if (register is null)
            {
                register = new Register();
            }

            loginRegisterMDIPanel.Controls.Clear();
            loginRegisterMDIPanel.Controls.Add(register.registerPanel);

        }
        private void LoadLogin()
        {

            if (login is null)
            {
                login = new Login();
            }

            loginRegisterMDIPanel.Controls.Clear();
            loginRegisterMDIPanel.Controls.Add(login.loginPanel);

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
