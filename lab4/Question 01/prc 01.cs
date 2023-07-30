using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilometerToMeterConversion
{
    class ConvertValues
    {
        public void KilometerToMeter()
        {
            Console.WriteLine("Please enter the distance in kilometers:");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            double meters = kilometers * 1000;

            Console.WriteLine("Distance in meters: " + meters);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConvertValues converter = new ConvertValues();
            converter.KilometerToMeter();
        }
    }
}

