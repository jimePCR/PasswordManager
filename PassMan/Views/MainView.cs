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
            int index = 1;
            userMV.Accounts = access.GetAccounts(userMV.Id);
            this.listAccounts.Rows.Clear();
            foreach (var account in userMV.Accounts)
            {
                this.listAccounts.Rows.Add(index, account.Name, account.Password, account.Note);
                index++;
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
            int index = 1;
            string input = Interaction.InputBox("Digita tu llave maestra", "Llave maestra", "...");
            if (HasherService.Verify(input, userMV.MasterPass))
            {
                emailService.sendEmail(userMV);
                input = Interaction.InputBox("Se envio un codigo de verificación a tu correo, digita el código que se te envio", "Codigo Verificación", "...");
                if(emailService.code == Convert.ToInt32(input))
                {
                    listAccounts.Rows.Clear();
                    foreach (var account in userMV.Accounts)
                    {
                        this.listAccounts.Rows.Add(index, account.Name, EncryptService.Decrypt(account.Password, userMV.MasterPass), account.Note);
                        index++;
                    }
                }else
                    MessageBox.Show("Codigo incorrecto");
            }
            else
                MessageBox.Show("Llave incorrecta");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
