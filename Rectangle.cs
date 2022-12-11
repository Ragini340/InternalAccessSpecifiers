using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalAccessSpecifiers
{
    class Rectangle
    {
        internal double length;
        internal double width;

        double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length is: {0}", length);
            Console.WriteLine("Width is: {0}", width);
            Console.WriteLine("Area is: {0}", GetArea());
        }
    }
  }