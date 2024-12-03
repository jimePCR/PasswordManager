using System;
using System.Windows.Forms;

namespace PassMan
{
    public partial class Form1 : Form
    {

        private DataAccess access = new DataAccess();

        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            User us = access.ValidateUser(userValue.Text);
            if (HasherService.Verify(this.passValue.Text, us.Password))
                MessageBox.Show(us.Id + " " + us.Name + " " + us.Email + " " + us.Password + " " + us.MasterPass);
            else
                MessageBox.Show("Gua gua");
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.Show();
        }
    }
}
