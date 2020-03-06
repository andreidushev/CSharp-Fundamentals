using System;

namespace SushiTIme
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeSushi = Console.ReadLine();
            string nameRestourant = Console.ReadLine();
            int porcion = int.Parse(Console.ReadLine());
            string delivery = Console.ReadLine();

            double pricePorcion = 0;

            if (typeSushi == "sashimi")
            {
                if (nameRestourant == "Sushi Zone")
                {
                    pricePorcion = 4.99;
                }
                else if (nameRestourant == "Sushi Time")
                {
                    pricePorcion = 5.49;
                }
                else if (nameRestourant == "Sushi Bar")
                {
                    pricePorcion = 5.25;
                }
                else if (nameRestourant == "Asian Pub")
                {
                    pricePorcion = 4.50;
                }
            }
            else if (typeSushi == "maki")
            {
                if (nameRestourant == "Sushi Zone")
                {
                    pricePorcion = 5.29;
                }
                else if (nameRestourant == "Sushi Time")
                {
                    pricePorcion = 4.69;
                }
                else if (nameRestourant == "Sushi Bar")
                {
                    pricePorcion = 5.55;
                }
                else if (nameRestourant == "Asian Pub")
                {
                    pricePorcion = 4.80;
                }
            }
            else if (typeSushi == "uramaki")
            {
                if (nameRestourant == "Sushi Zone")
                {
                    pricePorcion = 5.99;
                }
                else if (nameRestourant == "Sushi Time")
                {
                    pricePorcion = 4.49;
                }
                else if (nameRestourant == "Sushi Bar")
                {
                    pricePorcion = 6.25;
                }
                else if (nameRestourant == "Asian Pub")
                {
                    pricePorcion = 5.50;
                }
            }
            else if (typeSushi == "temaki")
            {
                if (nameRestourant == "Sushi Zone")
                {
                    pricePorcion = 4.29;
                }
                else if (nameRestourant == "Sushi Time")
                {
                    pricePorcion = 5.19;
                }
                else if (nameRestourant == "Sushi Bar")
                {
                    pricePorcion = 4.75;
                }
                else if (nameRestourant == "Asian Pub")
                {
                    pricePorcion = 5.50;
                }
            }

            double totalPrice = pricePorcion * porcion;

            if (nameRestourant != "Sushi Zone" && nameRestourant !="Sushi Time" && nameRestourant != "Sushi Bar" && nameRestourant != "Asian Pub")
            {
                Console.WriteLine($"{nameRestourant} is invalid restaurant!");
            }
            else if (delivery == "Y")
            {
                totalPrice = totalPrice + (totalPrice * 0.20);
                Console.WriteLine($"Total price: {Math.Ceiling(totalPrice)} lv.");
            }
            else if (delivery == "N")
            {
                Console.WriteLine($"Total price: {Math.Ceiling(totalPrice)} lv.");
            }
            
        }
    }
}
