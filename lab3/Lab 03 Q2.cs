using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the vowels.
            string vowels = "aeiouAEIOU";

            // Get the string from the user.
            string str = Console.ReadLine();

            // Initialize the vowel count.
            int vowelCount = 0;

            // Iterate over the string and count the vowels.
            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    vowelCount++;
                }
            }

            // Print the vowel count.
            Console.WriteLine("The number of vowels in the string is: " + vowelCount);
        }
    }
}




