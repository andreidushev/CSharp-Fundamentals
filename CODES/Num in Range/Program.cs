using System;

namespace Num_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid number");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(number);
        }
    }
}
