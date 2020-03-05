using System;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int ages = int.Parse(Console.ReadLine());
            int price = 0;

            if (dayType == "Weekday")
            {
                if ((ages >= 0 && ages <= 18) || (ages > 64 && ages <= 122))
                {
                    price = 12;
                }
                else if (ages > 18 && ages <= 64)
                {
                    price = 18;
                }
            }
            else if (dayType == "Weekend")
            {
                if ((ages >= 0 && ages <= 18) || (ages > 64 && ages <= 122))
                {
                    price = 15;
                }
                else if (ages > 18 && ages <= 64)
                {
                    price = 20;
                }
            }
            else if (dayType == "Holiday")
            {
                if (ages >= 0 && ages <= 18)
                {
                    price = 5;
                }
                else if (ages > 18 && ages <= 64)
                {
                    price = 12;
                }
                else if (ages > 64 && ages <= 122)
                {
                    price = 10;
                }
            }
            if (price != 0)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
