using System;

namespace _01._Christmas_Sweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBaklavaKG = double.Parse(Console.ReadLine());
            double priceMufinsKG = double.Parse(Console.ReadLine());
            double priceShtolenKG = double.Parse(Console.ReadLine());
            double priceCandysKG = double.Parse(Console.ReadLine());
            int priceBiscuitsKG = int.Parse(Console.ReadLine());

            double priceShtolen = priceBaklavaKG + (priceBaklavaKG * 0.60);
            double priceCandy = priceMufinsKG + (priceMufinsKG * 0.80);
            double priceBiscuit = priceBiscuitsKG * 7.50;

            double totalShtolen = priceShtolen * priceShtolenKG;
            double totalCandy = priceCandysKG * priceCandy;
            double totalBiscuit =priceBiscuit;
            double totalPrice = totalShtolen + totalCandy + totalBiscuit;
            Console.WriteLine($"{totalPrice:F2}");
            
        }
    }
}
