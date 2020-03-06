using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int vowelsCounter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (IsVowel(symbol))
                {
                    vowelsCounter++;
                }
            }
            Console.WriteLine(vowelsCounter);
        }

        static bool IsVowel(char symbol)
        {
            return symbol == 'a' || symbol == 'o' || symbol == 'u' || symbol == 'e' || symbol == 'i' || symbol == 'y' || symbol == 'q';
        }
    }
}
