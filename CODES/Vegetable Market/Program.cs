using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetable = double.Parse(Console.ReadLine());
            double priceFruit = double.Parse(Console.ReadLine());
            double kgVegetable = double.Parse(Console.ReadLine());
            double kgFruit = double.Parse(Console.ReadLine());

            double finalPriceVege = priceVegetable * kgVegetable;
            double finalPriceFruit = priceFruit * kgFruit;

            double evroPrice = (finalPriceFruit + finalPriceVege) / 1.94;
            Console.WriteLine($"{evroPrice:F2}");
            
        }
    }
}
