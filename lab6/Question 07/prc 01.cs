using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ArrayOperations
{
    public int ScalarSum(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }

    public int[] VectorSum(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            throw new ArgumentException("Both arrays should have the same size for vector sum.");
        }

        int[] result = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] + arr2[i];
        }
        return result;
    }

    public int[] VectorProduct(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            throw new ArgumentException("Both arrays should have the same size for vector product.");
        }

        int[] result = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] * arr2[i];
        }
        return result;
    }

    public int ScalarProduct(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            throw new ArgumentException("Both arrays should have the same size for scalar product.");
        }

        int product = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            product += arr1[i] * arr2[i];
        }
        return product;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the arrays: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr1 = new int[size];
        int[] arr2 = new int[size];

        Console.WriteLine("Enter values for the first array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Value {i + 1}: ");
            arr1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter values for the second array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Value {i + 1}: ");
            arr2[i] = int.Parse(Console.ReadLine());
        }

        ArrayOperations arrayOperations = new ArrayOperations();

        int scalarSum = arrayOperations.ScalarSum(arr1);
        Console.WriteLine("Scalar Sum: " + scalarSum);

        int[] vectorSum = arrayOperations.VectorSum(arr1, arr2);
        Console.WriteLine("Vector Sum:");
        PrintArray(vectorSum);

        int[] vectorProduct = arrayOperations.VectorProduct(arr1, arr2);
        Console.WriteLine("Vector Product:");
        PrintArray(vectorProduct);

        int scalarProduct = arrayOperations.ScalarProduct(arr1, arr2);
        Console.WriteLine("Scalar Product: " + scalarProduct);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
