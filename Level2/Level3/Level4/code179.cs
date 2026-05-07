using RabbitMQ.Client;
using System.Text;

// Create Connection
var factory = new ConnectionFactory()
{
    HostName = "localhost"
};

using var connection = factory.CreateConnection();

using var channel = connection.CreateModel();

// Create Queue
channel.QueueDeclare(
    queue: "studentQueue",
    durable: false,
    exclusive: false,
    autoDelete: false,
    arguments: null);

// Message
string message = "Hello Student";

// Convert message to byte
var body = Encoding.UTF8.GetBytes(message);

// Send Message
channel.BasicPublish(
    exchange: "",
    routingKey: "studentQueue",
    basicProperties: null,
    body: body);

Console.WriteLine("Message Sent: " + message);