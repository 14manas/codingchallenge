using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insur.Exceptions
{
    internal class PolicyEXp
    {
        internal class PolicyNotFoundException : ApplicationException
        {
            public PolicyNotFoundException() { }
            public PolicyNotFoundException(string message) : base(message)
            {

            }
        }
    }
}
