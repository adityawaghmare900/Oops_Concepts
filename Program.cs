namespace Oops_Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polymorphism polymorphism = new Polymorphism();
            polymorphism.add();
            Console.WriteLine("-----------------------");
            polymorphism.add(50, 63);
            Console.WriteLine("-----------------------");
            polymorphism.add(5.3f, 8.3f, 2.9f);
        }
    }
}