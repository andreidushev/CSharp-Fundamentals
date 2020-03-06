using System;

namespace Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double months = double.Parse(Console.ReadLine());
            double porcentComision = double.Parse(Console.ReadLine());
            double priceAmonth = double.Parse(Console.ReadLine());

            double porcent = porcentComision / 100;
            double totalPrice = Math.Floor(months / 2) * priceAmonth; 
            double halfPrice = priceAmonth - (priceAmonth * 0.20);
            double totalHalfPrice = Math.Ceiling(months / 2) * halfPrice;
            double endPrice = totalPrice + totalHalfPrice;
            double moneyForBroker = endPrice + (endPrice * porcent);
            Console.WriteLine($"Total: {moneyForBroker:F2}");
            
            
        }
    }
}
