using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            PrintSymbol(start, end);
            
        }

        static void PrintSymbol(char start, char end)
        {
            int firstSymbol = Math.Min(start,end);
            int secondSymbol = Math.Max(start,end);

            for (int i = firstSymbol + 1; i < secondSymbol; i++)
            {
                char symbol = (char)i;
                Console.Write(symbol + " ");
            }
        }
    }
}
