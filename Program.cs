using Constructor;
using System.Diagnostics;

namespace Vonstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car();
            Console.WriteLine(car.model);

            Bike bike = new Bike("Hayabhusa");
            Console.WriteLine(bike.model);
        }
    }
}