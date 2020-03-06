using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> passengersWagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = "";
            int morePassengers = 0;

            while ((input=Console.ReadLine()) != "end")
            {
                string[] splitedInput = input.Split(" ");

                if (splitedInput.Length == 1)
                {
                    morePassengers = int.Parse(splitedInput[0]);

                    for (int i = 0; i < passengersWagons.Count; i++)
                    {
                        if (passengersWagons[i] + morePassengers <= maxCapacity)
                        {
                            passengersWagons[i] += morePassengers;
                            break;
                        }
                    }
                }
                else
                {
                    morePassengers = int.Parse(splitedInput[1]);
                    passengersWagons.Add(morePassengers);
                }
            }
            string result = string.Join(" ", passengersWagons);
            Console.WriteLine(result);
            
        }
    }
}
