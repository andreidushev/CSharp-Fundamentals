using System;

namespace Exams
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyPerMonth = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double moneyNeeded = double.Parse(Console.ReadLine());

            double others = (moneyPerMonth * 0.30);
            double leftMoney = moneyPerMonth - (moneyNeeded + others);
            double savedMoney = leftMoney * months;
            double total = (leftMoney / moneyPerMonth) * 100;
            Console.WriteLine($"She can save {total:F2}%");
            Console.WriteLine($"{savedMoney:F2}");
            
        }
    }
}
