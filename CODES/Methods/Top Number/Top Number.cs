using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTopNumbers(num);
        }

        static void PrintTopNumbers(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                if (IsDevisibleBy8(i) && IsOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsOddDigit(int num)
        {
            while (num > 0)
            {
                if ((num % 10) % 2 == 1)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }

        static bool IsDevisibleBy8(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
