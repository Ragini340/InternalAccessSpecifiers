using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalAccessSpecifiers
{
    class Access
    {
        // String Variable declaring as internal
        internal string name;
        public void print()
        {
            Console.WriteLine("My name is " + name);
        }
    }
}
