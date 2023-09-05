using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    {
        public abstract void Dog();

        public void cow()
        {
            Console.WriteLine("cow says: mow mow");
        }
    }

    class Barking : Animal {
        public override void Dog()
        {
            Console.WriteLine("dog is barking");
        }
    }

}

   

