using NUnit.Framework;
using Moq;

namespace MoqDemo
{
    // Interface
    public interface IMessage
    {
        string GetMessage();
    }

    // Class using interface
    public class Greeting
    {
        private readonly IMessage message;

        public Greeting(IMessage message)
        {
            this.message = message;
        }

        public string ShowMessage()
        {
            return message.GetMessage();
        }
    }

    // Test Class
    [TestFixture]
    public class GreetingTest
    {
        [Test]
        public void Message_Test()
        {
            // Create Mock Object
            var mock = new Mock<IMessage>();

            // Fake return value
            mock.Setup(x => x.GetMessage()).Returns("Hello Anjali");

            // Pass mock object
            Greeting g = new Greeting(mock.Object);

            // Test
            string result = g.ShowMessage();

            Assert.AreEqual("Hello Anjali", result);
        }
    }
}