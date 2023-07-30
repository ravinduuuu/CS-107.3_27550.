using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalaryAfterTaxConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the employee's salary:");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the tax rate (in decimal form, e.g., 0.2 for 20%):");
            double taxRate = Convert.ToDouble(Console.ReadLine());

            double taxAmount = salary * taxRate;
            double salaryAfterTax = salary - taxAmount;

            Console.WriteLine("Salary after tax: " + salaryAfterTax);
        }
    }
}
