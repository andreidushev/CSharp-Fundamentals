using System;
using System.Collections.Generic;

namespace SoftUni_parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> usernamePlate = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string comand = input[0];
                string name = input[1];

                if (comand == "register")
                {
                    string plate = input[2];

                    if (!usernamePlate.ContainsKey(name))
                    {
                        usernamePlate.Add(name, plate);
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }
                    else
                    {
                        string currentPlate = plate;
                        Console.WriteLine($"ERROR: already registered with plate number {currentPlate}");
                    }
                }
                else if (comand == "unregister")
                {
                    if (usernamePlate.ContainsKey(name))
                    {
                        usernamePlate.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var item in usernamePlate)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
