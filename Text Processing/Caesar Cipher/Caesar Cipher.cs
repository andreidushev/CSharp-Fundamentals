using System;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder text = new StringBuilder();

            foreach (var item in input)
            {
                char symbol = (char)(item + 3);
                text.Append(symbol);
            }

            Console.WriteLine(text);
        }
    }
}
