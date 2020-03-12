using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion2
{
    class SpecialisedPerson : IPerson,IAdvancedSender
    {
        private IAdvancedSender _sender;
        public int Age { get; set; }
        public string Name { get ; set ; }


        public SpecialisedPerson(IAdvancedSender sender, int age, string name)
        {
            _sender = sender;
            Age = age;
            Name = name;
        }

        public void RemoveMessageSent(string text)
        {
            _sender.RemoveMessageSent(text);
        }

        public void SendSomething(IPerson person)
        {
            _sender.SendSomething(person);
        }
    }
}
