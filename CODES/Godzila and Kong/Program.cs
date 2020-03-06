using System;

namespace Godzila_and_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            double priceOneStatist = double.Parse(Console.ReadLine());

            double discount;
            double dekor = 0.10 * budget;
            double moneyClothes = statisti * priceOneStatist;
            if (statisti > 150)
            {
                discount = 0.10 * moneyClothes;
            }
            else
            {
                discount = 0.0;
            }
            double totalCost = dekor + (moneyClothes - discount);
            double moneyleft = Math.Abs(budget - totalCost);
            if (totalCost > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyleft:F2} leva more.");
            }
            else if (totalCost <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyleft:F2} leva left.");
            }
        }
    }
}
