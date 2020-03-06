using System;

namespace Scolarship
{
    class Program
    {
        static void Main()
        {
            double incomeBgn = double.Parse(Console.ReadLine());
            double marks = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double social = 0.35 * minSalary;
            double exelentMark = marks * 25;
            bool isSocial = incomeBgn < minSalary && marks > 4.5;
            bool isExelent = marks >= 5.5;
            
            if (isExelent && isSocial)
            {
                if (social > exelentMark)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(exelentMark)} BGN");
                }
            }
            else if (isSocial)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
            }
            else if (isExelent)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(exelentMark)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
