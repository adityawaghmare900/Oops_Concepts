using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    //Multi-level Inheritance
    class Animal
    {
          public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

    }
    
    class Dog:Animal 
    { 
        public void bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }

    class Horse: Dog
    {
        public void run()
        {
            Console.WriteLine("Horse is running");
        }
    }

}
