using System;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPasangers = int.Parse(Console.ReadLine());
            int numberBusStops = int.Parse(Console.ReadLine());

            int totalpasangers = numberPasangers;

            for (int i = 1; i <= numberBusStops ; i++)
            {
                int passangersOut = int.Parse(Console.ReadLine());
                int passangresIn = int.Parse(Console.ReadLine());
                
                if (i % 1 == 0)
                {
                    totalpasangers += passangresIn + 2;
                    totalpasangers -= passangersOut + 2;
                }
                else
                {
                    totalpasangers += passangresIn + 2;
                    totalpasangers -= passangersOut;
                }
                
            }

            Console.WriteLine($"The final number of passengers is : {totalpasangers}");
        }
    }
}
