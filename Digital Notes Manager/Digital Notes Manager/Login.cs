using DevExpress.XtraEditors;

namespace Digital_Notes_Manager
{
    public partial class Login : XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        public static List<User> users = new List<User>()
        {
            new User() {
                Username = "Mario",
                Password = "123"
        },new User()
        {
            Username = "Joe",
                Password = "456"
        }
    }
            ;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            var user = users.FirstOrDefault(x => x.Username == userNameTxt.Text && x.Password == passwordTxt.Text);
            if (user != null)
            {
                Form form = new Form1();
                form.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Wrong Username or Password");
            }
        }
    }
}
