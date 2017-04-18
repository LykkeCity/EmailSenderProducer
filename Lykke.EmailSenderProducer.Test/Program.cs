using System.IO;
using System.Text;
using Lykke.EmailSenderProducer.Models;

namespace Lykke.EmailSenderProducer.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var settings = new ServiceBusEmailSettings();

            var sender = new EmailSenderProducer(settings, null);
            var email = new EmailMessage
            {
                Body = "Test",
                IsHtml = true,
                Subject = "Test",
                Attachments = new[]
                {
                    new EmailAttachment
                    {
                        FileName = "test1.txt",
                        ContentType = "plain/text",
                        Stream = new MemoryStream(Encoding.UTF8.GetBytes("test 1"))
                    },
                    new EmailAttachment
                    {
                        FileName = "test2.txt",
                        ContentType = "plain/text",
                        Stream = new MemoryStream(Encoding.UTF8.GetBytes("test 2"))
                    },
                    new EmailAttachment
                    {
                        FileName = "test3.txt",
                        ContentType = "plain/text",
                        Stream = new MemoryStream(Encoding.UTF8.GetBytes("test 3"))
                    }
                }
            };

            sender.SendEmailAsync("test@test.com", email).Wait();
        }
    }
}
