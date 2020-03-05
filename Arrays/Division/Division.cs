using System;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            if (n % 10 == 0)
            {
                num = 10;
            }
            else if (n % 7 == 0)
            {
                num = 7;
            }
            else if (n % 6 == 0)
            {
                num = 6;
            }
            else if (n % 3 == 0)
            {
                num = 3;
            }
            else if (n % 2 == 0)
            {
                num = 2;
            }
            if (num != 0)
            {
                Console.WriteLine($"The number is divisible by {num}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
