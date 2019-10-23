using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace PRG282_Project
{
    public class Email
    {
        public void SendEmail(string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.mail.yahoo.com");

                mail.From = new MailAddress("m.khwezi@yahoo.com");
                mail.To.Add("jannesventer09@gmail.com");
                mail.Subject = "Testing Email";
                mail.Body = message;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("m.khwezi@yahoo.com", "YaWena1997");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("Mail Sent"); 


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
