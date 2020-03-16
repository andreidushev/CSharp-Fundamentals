using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            string str1 = input[0];
            string str2 = input[1];

            string longest = "";
            string shortest = "";

            int result = 0;

            if (str1.Length > str2.Length)
            {
                longest = str1;
                shortest = str2;
            }
            else
            {
                longest = str2;
                shortest = str1;
            }

            for (int i = 0; i < longest.Length; i++)
            {
                if (i > shortest.Length -1)
                {
                    result += longest[i];
                }
                else
                {
                    result += longest[i] * shortest[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
