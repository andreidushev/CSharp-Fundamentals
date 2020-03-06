using System;

namespace Alkohol_Magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double beerLitres = double.Parse(Console.ReadLine());
            double wineLitre = double.Parse(Console.ReadLine());
            double RakiyaLitres = double.Parse(Console.ReadLine());
            double wiskeyLitres = double.Parse(Console.ReadLine());

            double priceRakiya = (0.5 * wiskeyPrice);
            double pricewine = priceRakiya -(0.4 * priceRakiya);
            double pricebeer = priceRakiya -(0.8 * priceRakiya);

            double sumRakiya = (priceRakiya * RakiyaLitres);
            double sumWine = (pricewine * wineLitre);
            double sumBeer = (pricebeer * beerLitres);
            double sumWiskey = (wiskeyPrice * wiskeyLitres);

            Console.WriteLine($"{sumBeer + sumRakiya + sumWine + sumWiskey:F2}");


        }
    }
}
