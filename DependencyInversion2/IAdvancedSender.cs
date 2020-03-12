using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion2
{
    interface IAdvancedSender : ISender
    {
        void RemoveMessageSent(string text);
    }
}
