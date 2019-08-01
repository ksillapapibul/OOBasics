using System;

namespace OOBasics.Polymorphism.example
{
    public class EmailSender : MessageSender 
    {
        public void Send(string message, string to)
        {
            Console.WriteLine($"Email message: {message} to:{to}");
        }
    }
}