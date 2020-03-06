using System;

namespace Wedding_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int quests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceForOne = 20;
            double moneyForQuests = quests * priceForOne;
            double moneyLefts = budget - moneyForQuests;
            double moneyForFireworks = moneyLefts * 0.40;
            double moneyForCharity = moneyLefts - moneyForFireworks;

            if (moneyForQuests > budget)
            {
                double moneyNeede = moneyForQuests - budget;
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(moneyNeede)} lv more.");
            }
            else
            {
                Console.WriteLine($"Yes! {Math.Round(moneyForFireworks)} lv are for fireworks and {Math.Round(moneyForCharity)} lv are for donation.");
            }
        }
    }
}
