using System;
using System.Windows.Forms;

namespace PassMan
{
    public partial class AddAccount : Form
    {
        private readonly DataAccess access = new DataAccess();
        private readonly User user;

        public AddAccount(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.userValue.Text != "" && passValue.Text != "")
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
                else
                    MessageBox.Show("Please enter all data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cancelAcc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
