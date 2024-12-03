using System;
using System.Windows.Forms;

namespace PassMan
{
    public partial class AddAccount : Form
    {
        private DataAccess access = new DataAccess();
        private User user;
        private MainView main;

        public AddAccount(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Account account = new Account
            {
                IdUser = user.Id,
                Name = this.userValue.Text,
                Password = EncryptService.Encrypt(this.passValue.Text, user.MasterPass),
                Note = this.notes.Text
            };
            access.InsertAccount(account);
            this.Close();
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
