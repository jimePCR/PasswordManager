using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PassMan
{
    public partial class MainView : Form
    {
        private DataAccess access = new DataAccess();
        private readonly User userMV = new User();
        private EmailService emailService = new EmailService();

        public MainView(User user)
        {
            InitializeComponent();
            userMV = user;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            addAccounts();
        }
        public void addAccounts()
        {
            try
            {
                userMV.Accounts = access.GetAccounts(userMV.Id);
                this.listAccounts.Rows.Clear();
                foreach (var account in userMV.Accounts)
                {
                    this.listAccounts.Rows.Add(account.Name, account.Password, account.Note);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addAccount_Click(object sender, EventArgs e)
        {
            AddAccount addVW = new AddAccount(userMV);
            addVW.ShowDialog();
            addAccounts();
        }

        private void showPass_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox("Please enter your master key", "Master key", "...");
                if (HasherService.Verify(input, userMV.MasterPass))
                {
                    emailService.sendEmail(userMV);
                    input = Interaction.InputBox("We've sent an email to verify your identity. Please enter the verification code.", "Verification code", "...");
                    if (emailService.code == Convert.ToInt32(input))
                    {
                        listAccounts.Rows.Clear();
                        foreach (var account in userMV.Accounts)
                        {
                            this.listAccounts.Rows.Add(account.Name, EncryptService.Decrypt(account.Password, userMV.MasterPass), account.Note);
                        }
                    }
                    else
                        MessageBox.Show("Incorrect verificacion code");
                }
                else
                    MessageBox.Show("Incorrect master key");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
