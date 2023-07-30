using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the number from the user.
            int number = int.Parse(Console.ReadLine());

            // Initialize the sum of the digits.
            int sum = 0;

            // Iterate over the number and add the digits to the sum.
            for (int i = number; i > 0; i /= 10)
            {
                int digit = i % 10;
                sum += digit;
            }

            // Print the sum of the digits.
            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }
}


