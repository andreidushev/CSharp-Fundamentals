using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintMatrix(n);
        }

        static void PrintMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = 1; k < n; k++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine(n + " ");
            }
        }
    }
}
