using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion2
{
    interface IDataReader
    {
        void QueryHobbies(IEnumerable<string> hobbies);
    }
}
