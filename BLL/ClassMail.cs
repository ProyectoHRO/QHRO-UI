using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClassMail
    {
        public string MakeMail(string emailToSend, string body, string subject, string response)
        {
            try
            {
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add(emailToSend);
                msg.Subject = subject;
                msg.SubjectEncoding = System.Text.Encoding.UTF8;

                msg.Body = body;
                msg.BodyEncoding = System.Text.Encoding.UTF8;

                msg.From = new System.Net.Mail.MailAddress("quirofanoshro@gmail.com");

                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("quirofanoshro@gmail.com", "QuirofanosHROGT");

                client.Port = 587;
                client.EnableSsl = true;

                client.Host = "smtp.gmail.com";
                client.Send(msg);
                return response;
            }
            catch (Exception)
            {
                return "Error al enviar";
            }
        }
    }
}
