using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Week6_Abstraction
{
    interface ILog
    {
        void Log(string message);
        void Log(Exception ex);
    }


    class TextFileLog : ILog
    {
        string path;
        public TextFileLog(string fileName)
        {
            path = fileName;
        }

        public void Log(string message)
        {
            System.IO.File.WriteAllText(path, message);
        }

        public void Log(Exception ex)
        {
            System.IO.File.WriteAllText(path, ex.Message);
        }
    }

    class EmailLog : ILog
    {
        string recipient;
        string from;
        string passwordOfFromAccount;
        public EmailLog(string recipientEmailAddress, string _from, string _passwordOfFromAccount)
        {
            from = _from;
            passwordOfFromAccount = _passwordOfFromAccount;
            recipient = recipientEmailAddress;
        }
        public void Log(string message)
        {
            MailMessage mm = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            mm.From = new MailAddress(from);
            mm.To.Add(new MailAddress(recipient));
            mm.Subject = "Log From Application #1";
            mm.IsBodyHtml = true; //to make message body as html  
            mm.Body = message;
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com"; //for gmail host  
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(from, passwordOfFromAccount);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(mm);
        }

        public void Log(Exception ex)
        {
            Log(ex.Message);
        }
    }
}
