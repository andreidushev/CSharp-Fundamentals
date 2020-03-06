using System;

namespace Mid_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitAday = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int otherFactory = int.Parse(Console.ReadLine());

            int totalBiscuits = 0;

            for (int i = 1; i <= workersCount; i++)
            {
                if (i % 3 == 0)
                {
                    if (biscuitAday != 1)
                    {
                        totalBiscuits += (int)(0.75 * biscuitAday * workersCount);
                    }
                }
                else
                {
                    totalBiscuits += biscuitAday * workersCount;
                }
            }

            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");

            int diff = totalBiscuits - otherFactory;
            decimal percents = diff / (decimal)otherFactory * 100;
            Console.WriteLine($");
        }
    }
}
