using System;
using System.Collections.Generic;
using System.Linq;

namespace Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split();


            var charsCount = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                foreach (var letter in text[i])
                {
                    if (!charsCount.ContainsKey(letter))
                    {
                        charsCount[letter] = 0;
                    }
                    charsCount[letter]++;
                }
            }
            foreach (var chars in charsCount)
            {
                Console.WriteLine($"{chars.Key} -> {chars.Value}");
            }
        }
    }
}
