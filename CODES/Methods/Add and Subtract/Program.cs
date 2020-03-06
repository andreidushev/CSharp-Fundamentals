using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int finalSum = TheFinalSum(n1,n2,n3);
            Console.WriteLine(finalSum);
        }

        static int TheSumOfTwo(int n1, int n2, int n3)
        {
            int sum1 = n1 + n2 + n3;
            return sum1;
        }

        static int TheFinalSum(int n1, int n2, int n3)
        {
            int totalSum = (n1+n2) - n3;
            return totalSum;
        }
    }
}
