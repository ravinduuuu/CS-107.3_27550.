using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ArrayHelper
{
    public int[] InputValues()
    {
        int[] arr = new int[10];

        Console.WriteLine("Enter 10 values for the array:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Value {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        return arr;
    }

    public int FindMinimum(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
        }
        return min;
    }

    public int FindMaximum(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }

    public double CalculateAverage(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return (double)sum / arr.Length;
    }

    public int[] ReverseArray(int[] arr)
    {
        int[] reversedArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            reversedArr[i] = arr[arr.Length - i - 1];
        }
        return reversedArr;
    }
}



class Program
{
    static void Main(string[] args)
    {
        ArrayHelper arrayHelper = new ArrayHelper();

        int[] arr = arrayHelper.InputValues();

        int min = arrayHelper.FindMinimum(arr);
        int max = arrayHelper.FindMaximum(arr);
        double average = arrayHelper.CalculateAverage(arr);
        int[] reversedArr = arrayHelper.ReverseArray(arr);

        Console.WriteLine("Minimum value: " + min);
        Console.WriteLine("Maximum value: " + max);
        Console.WriteLine("Average value: " + average);

        Console.WriteLine("Array in reverse order:");
        foreach (int num in reversedArr)
        {
            Console.Write(num + " ");
        }
    }
}
