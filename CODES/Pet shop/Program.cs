using System;

namespace Pet_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int dogs = int.Parse(Console.ReadLine());
            double price = dog * 2.50;
            double priceOther = dogs * 4.00;

            double finalsum = price + priceOther;
            Console.WriteLine($"{finalsum:F2} lv.");
            
        }
    }
}
