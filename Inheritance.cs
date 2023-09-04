using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    //Multiple Inheritance
    interface A1
    {
        public void Method1();
    }
    interface A2
    {
        public void Method2();
    } 
    
    class Mul_Inheritance : A1, A2
    {
        public void Method1()
        {
            Console.WriteLine("Method 1 is called");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2 is called");
        }
    }
    

}
