using System;

namespace Space_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            double widghShip = double.Parse(Console.ReadLine());
            double longShip = double.Parse(Console.ReadLine());
            double lenghShip = double.Parse(Console.ReadLine());
            double lenghAstronaughs = double.Parse(Console.ReadLine());

            double totalRoom = widghShip * longShip * lenghShip;
            double oneRoom = (lenghAstronaughs + 0.40) * 2 * 2;
            double whatRoom = Math.Floor(totalRoom / oneRoom);

            if (whatRoom >= 3 && whatRoom <= 10)
            {
                Console.WriteLine($"The spacecraft holds {whatRoom} astronauts.");
            }
            else if (whatRoom < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (whatRoom > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
