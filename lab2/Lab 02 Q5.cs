using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddMultipleInputsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
            }
        }
    }
}




