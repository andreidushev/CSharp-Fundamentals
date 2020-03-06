using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double wide = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double volume = double.Parse(Console.ReadLine());
            double percent = volume * 0.01;


            double tank = (lenght * wide * hight) /1000.0;
            double usedVolume = percent * tank;
            double result = tank - usedVolume;
            Console.WriteLine("{0:F3}" , result);

        }
    }
}
