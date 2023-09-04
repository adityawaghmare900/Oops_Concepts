using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    //Method Overloading
    class Polymorphism
    {
        int a = 20, b = 30, c = 0;
        public void add()
        {
            c = a + b;
            Console.WriteLine(c);
        }
       public void add(int a, int b)
        {
            c = a + b;
            Console.WriteLine(c);
        }
        public void add(float a, float b, float c)
        {
            c = a + b + c;
            Console.WriteLine(c);
        }
    }
}