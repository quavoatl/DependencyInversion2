using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion2
{
    class Messenger : IAdvancedSender
    {
        public void RemoveMessageSent(string text)
        {
            Console.WriteLine($"You just deleted the message: {text}");
        }

        public void SendSomething(string text)
        {
            Console.WriteLine($"Sending a message with the text: {text} via Messenger");
        }
    }
}
