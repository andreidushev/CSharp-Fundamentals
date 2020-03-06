using System;
using System.Collections.Generic;

namespace Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int courseBonus = int.Parse(Console.ReadLine());

            double newbonus = 0;
            double newlecture = 0;

            double maxbonus = 0;
            double maxlecture = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double atendance = double.Parse(Console.ReadLine());

                double totalbonus = atendance / lecturesCount * (5 + courseBonus);

                newbonus = totalbonus;
                newlecture = atendance;

                if (newbonus > maxbonus && newlecture > maxlecture)
                {
                    maxbonus = totalbonus;
                    maxlecture = atendance;

                }
            }


            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxbonus)}.");
            Console.WriteLine($"The student has attended {maxlecture} lectures.");
        }
    }
}
