using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public static class MailMessageExtenshons
    {
        public static string GetInfo(this MailMessage mailMessage)
        {
            return $"From: {mailMessage.From}. To: {mailMessage.To}. CC: {mailMessage?.CC}. " +
                   $"Subject: {mailMessage?.Subject ?? "no subject"}. Body: {mailMessage?.Body}.";
        }
    }
}
