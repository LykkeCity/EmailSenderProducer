using System.IO;

namespace Lykke.EmailSenderProducer.Models
{
    public class EmailAttachment
    {
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public Stream Stream { get; set; }
    }
}
