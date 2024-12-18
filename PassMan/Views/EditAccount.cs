using System;
using System.Windows.Forms;

namespace PassMan.Views
{

    public partial class EditAccount : Form
    {
        private readonly DataAccess access = new DataAccess();
        private readonly Account account;
        private readonly string masterPass = "";
        public EditAccount(Account account, string masterPass)
        {
            InitializeComponent();
            this.account = account;
            this.userValue.Text = account.Name;
            this.passValue.Text = account.Password;
            this.notes.Text = account.Note;
            this.masterPass = masterPass;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.userValue.Text != "" && passValue.Text != "")
                {
                    this.account.Name = this.userValue.Text;
                    this.account.Password = EncryptService.Encrypt(this.passValue.Text, masterPass);
                    this.account.Note = this.notes.Text;
                    access.updateAccount(account);
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
