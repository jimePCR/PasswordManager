using System;
using System.Windows.Forms;

namespace PassMan
{
    public partial class Login : Form
    {

        private readonly DataAccess access = new DataAccess();
        private EmailService emailService = new EmailService();

        public Login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.userValue.Text != "" && this.passValue.Text != "")
                {
                    User us = access.ValidateUser(userValue.Text);
                    if (HasherService.Verify(this.passValue.Text, us.Password))
                    {
                        this.Hide();
                        MainView main = new MainView(us);
                        main.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Incorrect Password");
                }
                else
                    MessageBox.Show("Please enter all data");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.Show();
        }
    }
}
