using CustomPrismApp.Services.Interfaces;

namespace CustomPrismApp.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
