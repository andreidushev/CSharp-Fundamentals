using System;
using System.Collections.Generic;
using System.Linq;

namespace House_party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                CommandProm(people);
            }
            PrintPeople(people);
        }

        private static void PrintPeople(List<string> people)
        {
            foreach (var imena in people)
            {
                Console.WriteLine(imena);
            }
        }

        private static void CommandProm(List<string> people)
        {
            string comand = Console.ReadLine();
            string[] imena = comand
                .Split(' ')
                .ToArray();

            string name = imena[0];

            if (imena.Length == 3)
            {
                AddPeople(people, name);
            }
            else if (imena.Length == 4)
            {
                RemovePeople(people, name);
            }
        }

        private static void AddPeople(List<string> people, string name)
        {
            if (people.Contains(name))
            {
                Console.WriteLine($"{name} is already in the list!");
            }
            else
            {
                people.Add(name);
            }
        }

        private static void RemovePeople(List<string> people, string name)
        {
            if (people.Contains(name))
            {
                people.Remove(name);
            }
            else
            {
                Console.WriteLine($"{name} is not in the list!");
            }
        }
    }
}
