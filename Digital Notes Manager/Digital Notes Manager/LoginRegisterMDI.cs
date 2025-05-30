namespace Digital_Notes_Manager
{
    public partial class LoginRegisterMDI : Form
    {
        Login login;
        Register register;

        public LoginRegisterMDI()
        {
            InitializeComponent();
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
    }
}
