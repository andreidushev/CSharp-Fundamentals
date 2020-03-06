using System;

namespace _02._Christmas_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyWanted = double.Parse(Console.ReadLine());
            int fentaziBook = int.Parse(Console.ReadLine());
            int horrorBook = int.Parse(Console.ReadLine());
            int romansBook = int.Parse(Console.ReadLine());

            double priceFentazi = fentaziBook * 14.90;
            double priceHorror = horrorBook * 9.80;
            double priceRomans = romansBook * 4.30;
            double totalSum = priceRomans + priceHorror + priceFentazi;

            double ddsPrice =(totalSum) * 0.20;
            double moneyLeft = totalSum - ddsPrice;

            if (moneyLeft > moneyWanted)
            {
                double moneyMore = moneyLeft - moneyWanted;
                double employeeMoney = Math.Floor(moneyMore * 0.10);
                double totalMoney = moneyMore - employeeMoney;
                double endSum = totalMoney + moneyWanted;
                Console.WriteLine($"{endSum:F2} leva donated.");
                Console.WriteLine($"Sellers will receive {employeeMoney} leva.");
            }
            else if (moneyLeft < moneyWanted)
            {
                double needeMore = moneyWanted - moneyLeft;
                Console.WriteLine($"{needeMore:F2} money needed.");
            }
            

            
        }
    }
}
