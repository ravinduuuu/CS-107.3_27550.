using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleGeometryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Circumference: " + circumference);
        }
    }
}



