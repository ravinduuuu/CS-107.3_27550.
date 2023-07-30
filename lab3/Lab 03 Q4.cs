 using System;

namespace FactorialProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial of the number: " + factorial);
        }
    }
}
