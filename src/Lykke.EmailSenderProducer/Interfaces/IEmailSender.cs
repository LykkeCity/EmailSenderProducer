using System.Threading.Tasks;
using Lykke.EmailSenderProducer.Models;

namespace Lykke.EmailSenderProducer.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, EmailMessage emailMessage, string sender = null);
    }
}
