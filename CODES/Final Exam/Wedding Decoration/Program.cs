using System;

namespace Wedding_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double balloonPrice = 0.1;
            double flowerPrice = 1.5;
            double candlePrice = 0.5;
            double ribbonPrice = 2;

            int balloonCount = 0;
            int flowerCount = 0;
            int candleCount = 0;
            int ribbonCount = 0;

            double budget = double.Parse(Console.ReadLine());
            string command = "";

            double moneySpent = 0;

            while (budget > 0)
            {
                command = Console.ReadLine();

                if (command != "stop")
                {
                    int count = int.Parse(Console.ReadLine());

                    if (command == "balloons")
                    {
                        double price = count * balloonPrice;
                        balloonCount += count;
                        moneySpent += price;
                        budget -= price;
                    }
                    else if (command == "flowers")
                    {
                        double price = count * flowerPrice;
                        flowerCount += count;
                        moneySpent += price;
                        budget -= price;
                    }
                    else if (command == "candles")
                    {
                        double price = count * candlePrice;
                        candleCount += count;
                        moneySpent += price;
                        budget -= price;
                    }
                    else if (command == "ribbon")
                    {
                        double price = count * ribbonPrice;
                        ribbonCount += count;
                        moneySpent += price;
                        budget -= price;
                    }
                }
                else
                {
                    break;
                }

            }

            if (command == "stop")
            {
                Console.WriteLine($"Spend money: {moneySpent:F2}");
                Console.WriteLine($"Money left: {budget:F2}");
            }
            else
            {
                Console.WriteLine("All money is spent!");
            }

            Console.WriteLine($"Purchased decoration is {balloonCount} balloons, {ribbonCount} m ribbon, {flowerCount} flowers and {candleCount} candles.");
        }
    }
    
}
