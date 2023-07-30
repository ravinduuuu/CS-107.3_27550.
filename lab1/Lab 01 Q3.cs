using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("Summation: " + sum);
        }
    }
}
