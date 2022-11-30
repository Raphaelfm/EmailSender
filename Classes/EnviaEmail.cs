using System.Net;
using System.Net.Mail;

namespace EmailSender.Classes
{
    public class EnviaEmail
    {
        public void Email(string assunto, string mensagem, string seuEmail, string senhaEmail, string emailDestinatario)
        {
            try
            {
                var smtp = new SmtpClient
                {
                    Host = "SMTP.office365.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(seuEmail, senhaEmail)
                };
                using (var smtpMessage = new MailMessage(seuEmail, emailDestinatario))
                {
                    smtpMessage.Subject = assunto;
                    smtpMessage.Body = mensagem;
                    smtpMessage.IsBodyHtml = false;
                    smtp.Send(smtpMessage);
                }
            }
            catch (Exception ex)
            {
                //todo: add logging integration
                //throw;
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}