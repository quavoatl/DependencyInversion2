using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion2
{
    interface ISender
    {
        void SendSomething(IPerson person);
    }
}
