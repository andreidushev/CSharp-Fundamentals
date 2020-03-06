using System;

namespace yard_greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yards = double.Parse(Console.ReadLine());
            double price = yards * 7.61;
            double discount = 0.18 * price;
            double finalPrice = price - discount;
            Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}
