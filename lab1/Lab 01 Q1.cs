using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's name and batch.
            string name = Console.ReadLine();
            string batch = Console.ReadLine();

            // Print the user's name and batch.
            Console.WriteLine("Your name is:" + name);
            Console.WriteLine("Your batch is:" + batch);
        }
    }
}
