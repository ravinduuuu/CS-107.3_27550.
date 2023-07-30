using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SumOfTwoNumbersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;

            Console.WriteLine("Sum: " + sum);
        }
    }
}

