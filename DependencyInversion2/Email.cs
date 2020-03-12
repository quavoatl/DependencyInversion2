using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion2
{
    class Email : ISender
    {
        public void SendSomething(string text)
        {
            Console.WriteLine($"Sending the message : {text} via Email");
        }
    }
}
