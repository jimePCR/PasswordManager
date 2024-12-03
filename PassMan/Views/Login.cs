using System;
using System.Windows.Forms;

namespace PassMan
{
    public partial class Login : Form
    {

        private DataAccess access = new DataAccess();

        public Login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
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
