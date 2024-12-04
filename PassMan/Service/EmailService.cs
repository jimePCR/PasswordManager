using MimeKit;
using System;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;
using FluentValidation;
using FluentValidation.Validators;

namespace PassMan
{
    public class EmailService : AbstractValidator<string>
    {
        private readonly string Email = Environment.GetEnvironmentVariable("email");
        private readonly string Password = Environment.GetEnvironmentVariable("passEmail");
        public int code = 0;

        public EmailService()
        {
            RuleFor(email => email).EmailAddress();
        }

        private BodyBuilder CreateMessage(string userName)
        {
            Random random = new Random();
            code = random.Next(0, 999);
            var builder = new BodyBuilder();

            builder.HtmlBody = string.Format(@"<p>Hello {0},<br>
                <p>Your verification code is:<br>
                <p>{1}<br>
                <p>-- Sir Bigotes<br>
                ", userName, code);
            return builder;
        }

        public bool sendEmail(User user)
        {
            try
            {
                if (user.Email != "")
                {
                    var result = this.Validate(user.Email);
                    if (result.IsValid)
                    {
                        var message = new MimeMessage();
                        message.From.Add(new MailboxAddress("Bigo", this.Email));
                        message.To.Add(new MailboxAddress(user.Name, user.Email));
                        message.Subject = "Verification Code";
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
                        MessageBox.Show("Email is invalid");
                }
                else
                    MessageBox.Show("Wrong email");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
