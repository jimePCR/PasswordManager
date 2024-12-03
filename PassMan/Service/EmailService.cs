using MimeKit;
using System;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace PassMan
{
    public  class EmailService
    {
        private readonly string Email = Environment.GetEnvironmentVariable("email");
        private readonly string Password = Environment.GetEnvironmentVariable("passEmail");
        
        private BodyBuilder CreateMessage(string userName)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 999);
            var builder = new BodyBuilder();

            builder.HtmlBody = string.Format(@"<p>Hola {0},<br>
                <p>Clave temporal de verificación:<br>
                <p>{1}<br>
                <p>-- Sir Bigotes<br>
                ", userName, randomNumber);
            return builder;
        }

        private bool sendEmail(User user)
        {
            if (user.Email != "")
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Bigo", this.Email));
                message.To.Add(new MailboxAddress(user.Name, user.Email));
                message.Subject = "Codigo de verificación";
                var builder = CreateMessage(user.Name);

                message.Body = builder.ToMessageBody();

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    client.Authenticate(Email, Password);
                    client.Send(message);
                    client.Disconnect(true);
                }
                return true;
            }
            else
                MessageBox.Show("Debes poner un email");
            return false;
        }
    }
}
