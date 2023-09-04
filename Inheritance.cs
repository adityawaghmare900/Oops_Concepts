using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    //hierarchical Inheritance
    class Animal
    {
          public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

    }
    
    class bird:Animal 
    { 
        public void fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    class Eagle: Animal
    {
        public void Hunt()
        {
            Console.WriteLine("Eagle is Hunting");
        }
    }

    class Penguin: Animal
    {
        public void swim()
        {
            Console.WriteLine("Penguin are swim");
        }
    }

}
