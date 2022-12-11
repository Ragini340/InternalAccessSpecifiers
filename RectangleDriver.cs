using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalAccessSpecifiers
{
    class RectangleDriver
    {
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();
            obj.length = 10.35;
            obj.width = 8.3;
            obj.Display();
            Console.ReadLine();
        }
    }
}
