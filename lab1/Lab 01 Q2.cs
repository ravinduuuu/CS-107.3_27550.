using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CircleAreaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine("The area of the circle is: " + area);
        }
    }
}
