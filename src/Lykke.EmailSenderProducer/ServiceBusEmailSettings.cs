using Lykke.EmailSenderProducer.Interfaces;

namespace Lykke.EmailSenderProducer
{
    public class ServiceBusEmailSettings : IServiceBusEmailSettings
    {
        public string NamespaceUrl { get; set; }
        public string PolicyName { get; set; }
        public string Key { get; set; }
        public string QueueName { get; set; }
    }
}
