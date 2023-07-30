using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArithmeticOperationsConsoleApp
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
            double subtraction = num1 - num2;
            double multiplication = num1 * num2;
            double division = num1 / num2;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Subtraction: " + subtraction);
            Console.WriteLine("Multiplication: " + multiplication);
            Console.WriteLine("Division: " + division);
        }
    }
}


