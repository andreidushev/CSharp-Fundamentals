using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int totalSteps = 0;

            while (input != "Going home")
            {
                totalSteps += int.Parse(input);
                if (totalSteps >= 10000)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (input == "Going home")
            {
                int stepsHome = int.Parse(Console.ReadLine());
                totalSteps += stepsHome;
            }
                if (totalSteps >= 10000)
                {
                  Console.WriteLine("Goal reached! Good job!");
                }
                else
                {
                  Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
                }
        }
    }
}
