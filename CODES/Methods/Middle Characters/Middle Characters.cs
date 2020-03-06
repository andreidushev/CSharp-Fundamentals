using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintMiddleSymbol(text);

        }

        static void PrintMiddleSymbol(string text)
        {
            if (text.Length % 2 == 0)
            {
                char firstSymbol = text[(text.Length / 2) - 1];
                Console.Write(firstSymbol + "");
                char secondSymbol = text[text.Length / 2];
                Console.Write(secondSymbol);

            }
            else
            {
                char firstSymbol = text[text.Length / 2];
                Console.WriteLine(firstSymbol);
            }
        }
    }
}
