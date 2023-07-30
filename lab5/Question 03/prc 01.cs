using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division:");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number 1:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter number 2:");
        double num2 = double.Parse(Console.ReadLine());

        double result = 0;

        CalculateValues calculator = new CalculateValues();

        switch (choice)
        {
            case 1:
                result = calculator.Addition(num1, num2);
                break;
            case 2:
                result = calculator.Subtraction(num1, num2);
                break;
            case 3:
                result = calculator.Multiplication(num1, num2);
                break;
            case 4:
                result = calculator.Division(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        Console.WriteLine("Your answer is: " + result);
    }
}

class CalculateValues
{
    public double Addition(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtraction(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiplication(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Division(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero");
            return double.NaN;
        }
        return num1 / num2;
    }
}


