using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ArrayHelper
{
    public int[] CreateArrayWithZeros(int size)
    {
        int[] arr = new int[size * 2];

        Console.WriteLine("Enter values for the array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Value {i + 1}: ");
            arr[i * 2] = int.Parse(Console.ReadLine());
            arr[i * 2 + 1] = 0;
        }

        return arr;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        ArrayHelper arrayHelper = new ArrayHelper();
        int[] arr = arrayHelper.CreateArrayWithZeros(size);

        Console.WriteLine("Values inside the array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
