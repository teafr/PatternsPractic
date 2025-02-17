using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MailMessageBuilder
    {
        private readonly MailMessage _mailMessage = new MailMessage();

        public MailMessageBuilder From(string mailAdress) 
        { 
            _mailMessage.From = new MailAddress(mailAdress); 
            return this;
        }

        public MailMessageBuilder To(string mailAdress)
        {
            _mailMessage.To.Add(new MailAddress(mailAdress));
            return this;
        }

        public MailMessageBuilder Cc(string cc)
        {
            _mailMessage.CC.Add(cc);
            return this;
        }

        public MailMessageBuilder Subject(string subject, Encoding encoding)
        {
            _mailMessage.Subject = subject;
            _mailMessage.SubjectEncoding = encoding;
            return this;
        }

        public MailMessageBuilder Body(string body, Encoding encoding)
        {
            _mailMessage.Body = body;
            _mailMessage.BodyEncoding = encoding;
            return this;
        }

        public MailMessage Build()
        {
            return _mailMessage;
        }
    }
}
