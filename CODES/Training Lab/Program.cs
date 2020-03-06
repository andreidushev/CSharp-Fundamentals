using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double widh = 70;
            double lenght = 120;
            double koridor = 100;

            double w = double.Parse(Console.ReadLine()) * 100;
            double h = (double.Parse(Console.ReadLine()) * 100) - koridor;

            double numDesks = Math.Floor(h / widh);
            double numDesk = Math.Floor(w / lenght);

            double numSeats = (numDesks * numDesk) - 3;
            Console.WriteLine(numSeats);

        }
    }
}
