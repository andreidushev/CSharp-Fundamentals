using System;

namespace Celsium_to_Farenhaid
{
    class Program
    {
        static void Main(string[] args)
        {

            double celsius = double.Parse(Console.ReadLine());

            double farenheid = celsius * 9 / 5 + 32;
            Console.WriteLine($"{farenheid:F2}");
        }
    }
}
