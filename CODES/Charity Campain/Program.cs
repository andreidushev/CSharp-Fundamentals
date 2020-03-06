using System;

namespace Charity_Campain
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double coockers = double.Parse(Console.ReadLine());
            double cakes = double.Parse(Console.ReadLine());
            double gofreti = double.Parse(Console.ReadLine());
            double pancakes = double.Parse(Console.ReadLine());

            double pricecakes = cakes * 45;
            double pricegofreti = gofreti * 5.80;
            double pricepancake = pancakes * 3.20;

            double totalday = (pricecakes + pricegofreti + pricepancake) * (coockers * days);
            totalday = totalday - (totalday * 1 / 8);

            Console.WriteLine($"{totalday:F2}");
            

        }
    }
}
