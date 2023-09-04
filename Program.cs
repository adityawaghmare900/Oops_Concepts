namespace Oops_Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penguin penguin = new Penguin();
            penguin.Eat();
            penguin.swim();

            Console.WriteLine("-------------------");
            Eagle eagle = new Eagle();
            eagle.Eat();
            eagle.Hunt();
        }
    }
}