using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            double sum1 = FirstSum(n1, n2);
            double sum2 = SecondSum(n1, n2);
            double finalSum = (sum1 / sum2);
            Console.WriteLine($"{finalSum:F2}");

        }

        static double FirstSum(int n1, int n2)
        {
            double sum1 = 1;
            for (double i = n1; i >=1; i--)
            {
                sum1 *= i;
            }
                return sum1;
        }

        static double SecondSum(int n1, int n2)
        {
            double sum2 = 1;
            for (double i = n2; i >= 1; i--)
            {
                sum2 *= i;
            }
                return sum2;
        }
    }
}
