using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            while (true)
            {
                var resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }
                var quantity = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(resource))
                {
                    dict[resource] = 0;
                }
                dict[resource] += quantity;
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
