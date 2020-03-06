using System;

namespace World_Swimmingpool_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double rekordSeconds = double.Parse(Console.ReadLine());
            double distanceMetric = double.Parse(Console.ReadLine());
            double secondsOneMeter = double.Parse(Console.ReadLine());

            double completedDistance = distanceMetric * secondsOneMeter;
            double resistanceSeconds = Math.Floor(distanceMetric / 15) * 12.5;
            double totalTime = completedDistance + resistanceSeconds;
            double diference = totalTime - rekordSeconds;

            if (rekordSeconds <= totalTime)
            {
                Console.WriteLine($"No, he failed! He was {diference:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            
        }
    }
}
