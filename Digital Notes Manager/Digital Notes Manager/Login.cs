using DevExpress.XtraEditors;
using Digital_Notes_Manager.Models;

namespace Digital_Notes_Manager
{
    public partial class Login : XtraForm
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

                var user = context.Users
                    .FirstOrDefault(u => u.Username == enteredUsername && u.Password == enteredPassword);

                if (user != null)
                {
                    this.Hide();
                    Form form = new Main_Form();
                    form.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("Wrong Username or Password");
                }
            }
        }
    }
}
