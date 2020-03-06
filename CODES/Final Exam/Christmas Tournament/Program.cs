using System;

namespace Christmas_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int wins = 0;
            int loses = 0;
            double money = 0;

            for (int i = 1; i <= days; i++)
            {
                string input = Console.ReadLine();
                int winforday = 0;
                int losesforday = 0;
                double moneyforDay = 0;

                while (input != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        winforday++;
                        moneyforDay += 20;
                    }
                    else if (result == "lose")
                    {
                        losesforday++;
                    }
                    input = Console.ReadLine();
                }
                if (winforday > losesforday)
                {
                    moneyforDay += moneyforDay * 0.10;
                    
                    wins++;
                }
                else
                {
                    loses++;
                }
                money += moneyforDay;
            }
            if (wins > loses)
            {
                 money+=money* 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {money:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {money:F2}");
            }
        }
    }
}
