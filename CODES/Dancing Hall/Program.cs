using System;

namespace Dancing_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());


            double areaHall = L * W;
            double wardraopArea = A * A;
            double benchArea = areaHall / 10;

            double freeSpace = areaHall - wardraopArea - benchArea;
            freeSpace = freeSpace * 10000;

           double dancers = Math.Floor(freeSpace / 7040);
            Console.WriteLine(dancers);
            
        }
    }
}
