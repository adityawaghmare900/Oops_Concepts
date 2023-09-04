using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    //Method Overriding
    class A
    {
        public virtual void show()
        {
            Console.WriteLine("Class A");
        }
    }

    class B : A
    {
        public override void show()
        {
            base.show();
            Console.WriteLine("Class B");
        }
    }
}