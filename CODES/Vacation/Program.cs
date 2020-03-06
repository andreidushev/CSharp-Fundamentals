using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double savedMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int counter = 0;

            while (savedMoney < moneyNeeded)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                days++;

                if (action == "spend")
                {
                    counter++;
                    if (counter == 5)
                    {
                        break;
                    }
                    if (money > savedMoney)
                    {
                        savedMoney = 0;
                    }
                    else
                    {
                     savedMoney -= money;
                    }
                }
                else if (action == "save")
                {
                    counter = 0;
                    savedMoney += money;
                }
            }

            if (counter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }
            if (savedMoney >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }

           
        }
    }
}
