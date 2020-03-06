using System;

namespace Lemonade_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilogramLimons = double.Parse(Console.ReadLine());
            double kilogramSugar = double.Parse(Console.ReadLine());
            double litresWater = double.Parse(Console.ReadLine());

            double limonJuice = kilogramLimons * 980;
            double finalJuice = limonJuice + litresWater * 1000 + (kilogramSugar * 0.30);
            double perGlass = Math.Floor(finalJuice / 150);
            double price =(perGlass * 1.20);
            Console.WriteLine($"All cups sold: {perGlass}");
            Console.WriteLine($"Money earned: {price:F2}");
        }
    }
}
