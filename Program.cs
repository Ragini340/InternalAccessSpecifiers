using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalAccessSpecifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Access obj = new Access();
            Console.Write("Enter your name:");
            // Accepting value in internal variable
            obj.name = Console.ReadLine();
            obj.print();
            Console.ReadLine();
        }
    }
}
