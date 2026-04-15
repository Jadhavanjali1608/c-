using System;

// Service interface
interface IMessageService
{
    void SendMessage(string message);
}

// Email service (implementation)
class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}

// SMS service (another implementation)
class SmsService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine("SMS sent: " + message);
    }
}

// Client class (depends on IMessageService)
class Notification
{
    private IMessageService _messageService;

    // Constructor Injection
    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify(string msg)
    {
        _messageService.SendMessage(msg);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Inject Email Service
        IMessageService service1 = new EmailService();
        Notification n1 = new Notification(service1);
        n1.Notify("Hello via Email");

        // Inject SMS Service
        IMessageService service2 = new SmsService();
        Notification n2 = new Notification(service2);
        n2.Notify("Hello via SMS");
    }
}