using System;
using System.Windows.Forms;

namespace PassMan
{
    public partial class CreateUser : Form
    {
        private DataAccess access = new DataAccess();

        public CreateUser()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (this.userValue.Text != "" || this.emailValue.Text != "" || this.passValue.Text != "" || this.masterValue.Text != "")
            {
                User us = new User
                {
                    Name = this.userValue.Text,
                    Password = HasherService.HashPass2(this.passValue.Text),
                    Email = this.emailValue.Text,
                    MasterPass = HasherService.HashPass2(this.masterValue.Text)
                };
                access.InsertUser(us);
                MessageBox.Show("Creación exitosa.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Debes poner llenar todos los datos");
            }
        }
    }
}
