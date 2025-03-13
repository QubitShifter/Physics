using System;

namespace HW_1
{
    class Arrays
    {
        static void Main()
        {
            Console.WriteLine("How many words will you enter?");
            int numberOfWords = int.Parse(Console.ReadLine());

            string[] words = new string[numberOfWords];

            for (int i = 0; i < numberOfWords; i++)
            {
                Console.WriteLine($"Please, enter word {i + 1}:");
                words[i] = Console.ReadLine();
            }

            string concat = string.Join(" ", words);

            Console.WriteLine(" \n you just said:");
            Console.WriteLine(concat);
        }
    }
}
