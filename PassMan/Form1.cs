using System;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Security;
using System.Security.Policy;

namespace PassMan
{
    public partial class Form1 : Form
    {
        private string Email = Environment.GetEnvironmentVariable("email"); // Email que envia
        private string Password = Environment.GetEnvironmentVariable("passEmail");
        private User user = new User();

        public Form1()
        {
            InitializeComponent();
        }

        private BodyBuilder CreateMessage()
        {
            Random random = new Random();
            int randomNumber = random.Next(0,999);
            var builder = new BodyBuilder();

            builder.HtmlBody = string.Format(@"<p>Hola {0},<br>
                <p>Clave temporal de verificación:<br>
                <p>{1}<br>
                <p>-- Sir Bigotes<br>
                ", this.user.Name, randomNumber);
            return builder;
        }

        private void enviarEmail_Click(object sender, EventArgs e)
        {
            //if (user.Email != "")
            //{
            //    var message = new MimeMessage();
            //    message.From.Add(new MailboxAddress("Bigo", Email));
            //    message.To.Add(new MailboxAddress(this.user.Name, this.user.Email));
            //    message.Subject = "Codigo de verificación";
            //    var builder = CreateMessage();

            //    message.Body = builder.ToMessageBody();

            //    using (var client = new SmtpClient())
            //    {
            //        client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            //        client.Authenticate(Email, Password);
            //        client.Send(message);
            //        client.Disconnect(true);
            //    }
            //    MessageBox.Show("Envio exitoso");
            //    this.emailValue.Text = "";
            //}
            //else
            //{
            //    MessageBox.Show("Debes poner un email");
            //}

            //string message = "Holi";
            //string key = HasherService.HashPass2("gatos");
            //string msmE = EncryptService.Encrypt(message, key);
            //string msmD = EncryptService.Decrypt(msmE, key);

            //MessageBox.Show("ENCRYPT = " + msmE +"\nDecrypt = " + msmD);
        }

        private void crearUser_Click(object sender, EventArgs e)
        {
            if (this.emailValue.Text != "" || this.emailValue.Text == "Email")
            {
                string pass = HasherService.HashPass2("gatitos");
                //string pass2 = HasherService.HashPass2(this.passValue.Text);

                this.user.Email = this.emailValue.Text;
                this.user.Name = "Jime";
                //MessageBox.Show("Creación exitosa " + pass);
                //MessageBox.Show("pass2 " + pass2);

                if (HasherService.Verify(this.passValue.Text, pass))
                    MessageBox.Show("Hi");
                else
                    MessageBox.Show("Hello");
            }
            else
            {
                MessageBox.Show("Debes poner un email");
            }
        }
    }
}
