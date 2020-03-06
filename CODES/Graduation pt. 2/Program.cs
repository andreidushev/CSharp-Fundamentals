using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = Console.ReadLine();
            int counter = 0;
            double marks = 0;

            while (counter < 12)
            {
                double mark = double.Parse(Console.ReadLine());

                if (mark >= 4.00)
                {
                    counter++;
                    marks += mark;
                }
                else if (mark < 4.00)
                {
                    counter += 0;
                    marks += 0;
                }
                
                
            }
            Console.WriteLine($"{student} graduated. Average grade: {marks/12:F2}");
        }
    }
}
