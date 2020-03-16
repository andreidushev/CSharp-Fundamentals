using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] num1 = Console.ReadLine().ToCharArray();
            int num2 = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            int reminder = 0;

            if (num2 == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (num1.Length == 0)
            {
                if (int.Parse(num1) == 0)
                {
                    Console.WriteLine(0);
                    return;
                }

            }

            for (int i = num1.Length -1; i >= 0; i--)
            {
                char currentChar = num1[i];
                int num = int.Parse(currentChar.ToString());

                int sum = (num * num2) + reminder;
                result.Append(sum % 10);
                reminder = sum / 10;
            }

            if (reminder != 0)
            {
                result.Append(reminder);
            }

            List<char> finalSum = result.ToString()
                .Reverse()
                .ToList();
            RemoveZeros(finalSum);

            Console.WriteLine(String.Join("",finalSum));
        }
        private static void RemoveZeros(List<char> finalSum)
        {
            if (finalSum[0] == '0')
            {
                int endIndex = 0;

                for (int i = 1; i < finalSum.Count; i++)
                {
                    if (finalSum[i] == '0')
                    {
                        endIndex = i - 1;
                    }
                }

                for (int i = 0; i < endIndex; i++)
                {
                    finalSum.RemoveAt(0);
                }
            }
        }
    }
}
