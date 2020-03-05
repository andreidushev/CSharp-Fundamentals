using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            decimal pricePerPerson = 0;

            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 8.45M;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80M;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46M;
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 10.90M;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.60M;
                            break;
                        case "Sunday":
                            pricePerPerson = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 15;
                            break;
                        case "Saturday":
                            pricePerPerson = 20;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50M;
                            break;
                    }
                    break;
            }

            decimal totalPrice = pricePerPerson * num;

            if (type == "Students" && num >= 30)
            {
                totalPrice = totalPrice * 0.85M;
            }
            else if (type == "Business" && num >= 100)
            {
                totalPrice -= pricePerPerson * 10;
            }
            else if (type == "Regular" && num >= 10 && num <= 20)
            {
                totalPrice = totalPrice * 0.95M;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
