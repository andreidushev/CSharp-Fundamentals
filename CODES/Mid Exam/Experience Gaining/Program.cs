using System;

namespace Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExp = double.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());

            double expCount = 0;
            int battleCount = 0;


            for (int i = 1; i <= battles; i++)
            {
                if (expCount < neededExp)
                {
                    double expGained = double.Parse(Console.ReadLine());

                    if (i == 3)
                    {
                        expCount += expGained + (expGained * 0.15);
                        battleCount++;
                    }
                    else if (i == 5)
                    {
                        expCount += expGained - (expGained * 0.10);
                        battleCount++;
                    }
                    else
                    {
                        expCount += expGained;
                        battleCount++;
                    }
                }
                else
                {
                    break;
                }

            }
            double neededMore = neededExp - expCount;
            if (expCount >= neededExp)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battleCount} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededMore:F2} more needed.");
            }
        }
    }
}
