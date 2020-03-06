using System;
using System.Collections.Generic;
using System.Linq;

namespace Tanks_Collector
{
    class Program
    {
        static void Main()
        {
            List<string> premiumTanks = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] arguments = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string comand = arguments[0];

                if (comand == "Add")
                {
                    AddTank(premiumTanks, arguments);
                }
                else if (comand == "Remove")
                {
                    RemoveTank(premiumTanks, arguments);
                }
                else if (comand == "Remove At")
                {
                    RemoveAt(premiumTanks, arguments);
                }
                else if (comand == "Insert")
                {
                    Insert(premiumTanks, arguments);
                }
            }
            Console.WriteLine(string.Join(", ", premiumTanks));
        }


        private static void Insert(List<string> premiumTanks, string[] arguments)
        {
            int index = int.Parse(arguments[1]);
            string tank = arguments[2];

            if (index > 0 && index <= premiumTanks.Count)
            {
                if (premiumTanks.Contains(tank))
                {
                    Console.WriteLine("Tank is already bought");
                }
                else
                {
                    premiumTanks.Insert(index, tank);
                    Console.WriteLine("Tank successfully bought");
                }
            }
            else
            {
                Console.WriteLine("Index out of range");
            }
        }

        private static void RemoveAt(List<string> premiumTanks, string[] arguments)
        {
            int index = int.Parse(arguments[1]);

            if (index > 0 && index <= premiumTanks.Count)
            {
                premiumTanks.RemoveAt(index);
                Console.WriteLine("Tank successfully sold");
            }
        }

        private static void RemoveTank(List<string> premiumTanks, string[] arguments)
        {
            string tank = arguments[1];

            if (premiumTanks.Contains(tank))
            {
                Console.WriteLine("Tank successfully sold");
                premiumTanks.Remove(tank);
            }
            else
            {
                Console.WriteLine("Tank not found");
            }
        }

        private static void AddTank(List<string> premiumTanks, string[] arguments)
        {
            string tank = arguments[1];

            if (premiumTanks.Contains(tank))
            {
                Console.WriteLine("Tank is already bought");
            }
            else
            {
                premiumTanks.Add(tank);
                Console.WriteLine("Tank successfully bought");
            }
        }
    }
}
