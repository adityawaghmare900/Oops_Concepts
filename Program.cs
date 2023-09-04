namespace Oops_Concept
{
    internal class Program
    {
        int a = 10;
        int b = 20;
        int c = 0;
        void add()
        {
            c = a + b;
            Console.WriteLine("addition of " + a + " and " + b + " is: " + c);
        }
        void sub()
        {
            c=a - b;
            Console.WriteLine("substraction  of " + a + " and " + b + " is: " + c);
        }
        static void Main(string[] args)
        {
            Program Oops=new Program();
            
            Oops.add();
            Oops.sub();
        }
    }
}