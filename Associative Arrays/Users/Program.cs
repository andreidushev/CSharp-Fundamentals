using System;
using System.Collections.Generic;
using System.Linq;

namespace Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();
            
            string info = Console.ReadLine();
            while (info != "End")
            {
                string[] input = info.Split(" -> ").ToArray();

                string companY = input[0];
                string user = input[1];

                if (!company.ContainsKey(companY))
                {
                    company.Add(companY, new List<string>());
                }
                if (!company[companY].Contains(user))
                {
                    company[companY].Add(user);
                }
                info = Console.ReadLine();
            }

            foreach (var mvp in company.OrderBy(mvp => mvp.Key))
            {
                Console.WriteLine($"{mvp.Key}");
                foreach (var item in mvp.Value)
                {
                    Console.WriteLine($" -- {item}");
                }
            }
        }
    }
}
