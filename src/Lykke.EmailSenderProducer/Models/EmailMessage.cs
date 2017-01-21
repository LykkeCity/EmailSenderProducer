namespace Lykke.EmailSenderProducer.Models
{
    public class EmailMessage
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }
        public EmailAttachment[] Attachments { get; set; }
    }
}
