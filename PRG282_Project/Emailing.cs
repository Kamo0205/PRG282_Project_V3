using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace PRG282_Project
{
    class Emailing
    {
        public Emailing()
        {

        }

        public void SendEmail(string content)
        {
            MailMessage message = new MailMessage();
            SmtpClient server = new SmtpClient();
            message.From = new MailAddress("DankeSchoneM@gmail.com");
            message.To.Add(new MailAddress("Mcintyre.d@belgiumcampus.co.za"));
            message.Subject = "Secret Phrase";
            message.Attachments.Add(new Attachment(content));
            server.Port = 587;
            server.Host = "smtp.gmail.com";
            server.EnableSsl = true;
            server.Credentials = new NetworkCredential("DankeSchoneM@gmail.com", "4vT2$#HcJVz4snZ2Z#aw");
            server.DeliveryMethod = SmtpDeliveryMethod.Network;
            server.Send(message);
        }
    }
}
