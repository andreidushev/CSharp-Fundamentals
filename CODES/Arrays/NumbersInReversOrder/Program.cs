using System;

namespace NumbersInReversOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                arr[i] = numbers;
            }
            for (int i = arr.Length -1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
