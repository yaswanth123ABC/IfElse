using System;
namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;
            if (n % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else 
                {
                Console.WriteLine("odd number");
            }
        }
    }
}