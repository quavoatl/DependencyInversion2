using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion2
{
    class DataReader : IDataReader
    {
        public void QueryHobbies(IEnumerable<string> hobbies)
        {
            foreach(var h in hobbies)
            {
                Console.WriteLine("h");
            }
        }
    }
}
