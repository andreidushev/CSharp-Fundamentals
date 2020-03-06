using System;

namespace Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyForQuests = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int currentCouter = 0;
            int price = 0;

            while (input != "The restaurant is full")
            {
                int currentQuests = int.Parse(input);
                currentCouter += currentQuests;

                if (currentQuests >= 5)
                {
                    price += currentQuests * 70;
                }
                else
                {
                    price += currentQuests * 100;
                }

                input = Console.ReadLine();
            }

            if (price >= moneyForQuests)
            {
                Console.WriteLine($"You have {currentCouter} guests and {price - moneyForQuests} leva left.");
            }
            else if (price < moneyForQuests)
            {
                Console.WriteLine($"You have {currentCouter} guests and {price} leva income, but no singer.");
            }

        }
    }
}
