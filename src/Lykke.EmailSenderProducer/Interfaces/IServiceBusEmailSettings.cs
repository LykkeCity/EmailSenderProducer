namespace Lykke.EmailSenderProducer.Interfaces
{
    public interface IServiceBusEmailSettings
    {
        string NamespaceUrl { get; set; }
        string PolicyName { get; set; }
        string Key { get; set; }
        string QueueName { get; set; }
    }
}
