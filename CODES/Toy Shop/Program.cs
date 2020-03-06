using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceJourney = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int kukli = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double pricePuzzel = 2.60;
            double priceKukli = 3.00;
            double priceBears = 4.10;
            double priceMinions = 8.20;
            double priceTrucks = 2.00;

            double totallCash = (puzzels * pricePuzzel) + (kukli * priceKukli) + (bears * priceBears) + (minions * priceMinions) + (trucks * priceTrucks);
            int totallToys = puzzels + kukli + bears + minions + trucks;

            if (totallToys >= 50)
            {
                double disscount = totallCash * 0.25;
                totallCash = totallCash - disscount;
            }
            double taxPay = totallCash * 0.1;
            totallCash = totallCash - taxPay;

            if (totallCash >= priceJourney)
            {
                double difference = totallCash - priceJourney;
                Console.WriteLine($"Yes! {difference:F2} lv left.");
            }
            else
            {
                double difference = priceJourney - totallCash;
                Console.WriteLine($"Not enough money! {difference:F2} lv needed.");
            }
        }
    }
}
