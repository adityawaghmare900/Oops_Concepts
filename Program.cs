namespace Oops_Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse();
            horse.Eat();
            Console.WriteLine("--------------");
            horse.bark();
            Console.WriteLine("--------------");
            horse.run();
        }
    }
}