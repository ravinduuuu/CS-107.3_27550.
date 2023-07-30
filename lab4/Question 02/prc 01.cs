using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CircleAreaCircumference
{
    class FindValues
    {
        public double FindArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public double FindCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues finder = new FindValues();
            double area = finder.FindArea(radius);
            double circumference = finder.FindCircumference(radius);

            Console.WriteLine("Area of the circle: " + area);
            Console.WriteLine("Circumference of the circle: " + circumference);
        }
    }
}
