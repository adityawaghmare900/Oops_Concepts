using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Car
    {
        public String model;

        //defualt Constructor
        public Car()
        {
            model = "Fortuner";
        }
    }

    internal class Bike
    {
        public String model;
        public Bike(String bikeName)
        {
            model = bikeName;
        }
    }
    
}
