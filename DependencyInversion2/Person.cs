using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion2
{
    class Person : IPerson,ISender
    {
        private ISender _sender;
        private ICollection<string> hobbies;

        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> Hobbies => hobbies;

        public Person(string name, int age, ISender sender, ICollection<string> hobbies)
        {
            this.Name = name;
            this.Age = age;
            _sender = sender;
            this.hobbies = hobbies;
        }

        public void AddHobby(string hobby)
        {
            hobbies.Add(hobby);
        }

        public void SendSomething(IPerson person)
        {
            _sender.SendSomething(person);
        }
    }
}
