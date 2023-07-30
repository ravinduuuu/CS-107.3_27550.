using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilometerToMeterConversionWithReturn
{
    class ConvertValues
    {
        public double KilometerToMeter(double kilometers)
        {
            double meters = kilometers * 1000;
            return meters;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance in kilometers:");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            double meters = converter.KilometerToMeter(kilometers);

            Console.WriteLine("Distance in meters: " + meters);
        }
    }
}
