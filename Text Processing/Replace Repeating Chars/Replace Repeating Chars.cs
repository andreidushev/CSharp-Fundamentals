using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input += "0";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length - 1; i++)
            {
                char currentChar = input[i];

                for (int j = i + 1; j < input.Length; j++)
                {
                    char nextChar = input[j];

                    if (currentChar != nextChar)
                    {
                        sb.Append(currentChar);
                        i = j - 1;
                        break;
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
