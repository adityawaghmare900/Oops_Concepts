namespace Oops_Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encapsulation encapsulation = new Encapsulation();
            encapsulation.Name = "Aditya";
            encapsulation.salary = 25000;
            Console.WriteLine("Employee Name: "+encapsulation.Name);
            Console.WriteLine("Salary is :" + encapsulation.salary);
        }
    }
}