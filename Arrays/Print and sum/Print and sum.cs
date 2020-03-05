using System;

namespace Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = 0;
            int num = a;

            for (int i = a; i <= b; i++)
            {
                sum += i;
                Console.Write($"{num} ");
                num ++;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
