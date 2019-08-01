using System;
using OOBasics.Polymorphism.example;

namespace OOBasics.Polymorphism
{
    public class Example
    {
        public static void PerformTask()
        {
            //to some thing
            var messageSenders = new MessageSender[]
            {
                new SmsSender(),
                new EmailSender()
            };

            foreach (var messageSender in messageSenders)
            {
                messageSender.Send("message To be Send", "person to be sent");
            }
        }
    }
}