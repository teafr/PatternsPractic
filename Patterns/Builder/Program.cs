using System.Net.Mail;
using System.Text;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailMessage mailMessage = new MailMessageBuilder().From("from@dot.net")
                                                              .To("to@dot.net")
                                                              .Cc("cc@dot.net")
                                                              .Subject("Information", Encoding.UTF8)
                                                              .Body("Hello world!", Encoding.UTF8)
                                                              .Build();
        }
    }
}
