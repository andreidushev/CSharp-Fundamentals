using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark = int.Parse(Console.ReadLine());

            int failed = 0;
            int passed = 0;
            double gradeSum = 0;
            string problem = "";
            bool isFail = true;

            while (failed < mark)
            {
                string namejob = Console.ReadLine();
                if ("Enough" == namejob)
                {
                    isFail = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failed++;
                }
                gradeSum += grade;
                passed++;
                problem = namejob;
            }
            if (isFail)
            {
                Console.WriteLine($"You need a break, {mark} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum/passed:F2}");
                Console.WriteLine($"Number of problems: {passed}");
                Console.WriteLine($"Last problem: {problem}");
            }
        }
    }
}
