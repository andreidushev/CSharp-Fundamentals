using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = Console.ReadLine();
            double marks = 0;
            int counter = 1;
            int stop = 0;

            while (counter <= 12 && stop < 2)
            {
                double mark = double.Parse(Console.ReadLine());

                if (mark >= 4.00)
                {
                    counter++;
                    marks += mark;
                }
                else
                {
                    stop++;
                }
            }
            if (stop < 2)
            {
                 Console.WriteLine($"{student} graduated. Average grade: {marks/12:F2}");
            }
            else
            {
               Console.WriteLine($"{student} has been excluded at {counter} grade");
            }
        }
    }
}
