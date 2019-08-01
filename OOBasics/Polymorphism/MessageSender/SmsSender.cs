using System;

namespace OOBasics.Polymorphism.example
{
    public class SmsSender : MessageSender
    {
        public void Send(string message, string to)
        {
            Console.WriteLine($"SMS message: {message} to:{to}");
        }
    }
}