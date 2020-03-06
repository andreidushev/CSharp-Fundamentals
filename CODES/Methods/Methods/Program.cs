using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int smallest = SmallestOne(num1, num2, num3);
            Console.WriteLine(smallest);
        }

        static int SmallestOne(int a, int b, int c)
        {
            int smallest = 0;
            if (a <= b && a <= c)
            {
                smallest = a;
            }
            else if (b <= a && b <= c)
            {
                smallest = b;
            }
            else
            {
                smallest = c;
            }
            return smallest;
        }
    }
}
