using System;
using System.Collections.Generic;
using System.Linq;

namespace Invertory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();

            string comanded = Console.ReadLine();

            while (comanded != "Craft!")
            {
                string[] splited = comanded.Split(" - ");

                if (splited[0] == "Collect")
                {
                    if (!input.Contains(splited[1]))
                    {
                        input.Add(splited[1]);
                    }
                }
                else if (splited[0] == "Drop")
                {
                    if (input.Contains(splited[1]))
                    {
                        input.Remove(splited[1]);
                    }
                }
                else if (splited[0] == "Combine Items")
                {
                    var olditem = splited[1].Split(":");

                    int index = input.IndexOf(olditem[0]);
                    if (input.Contains(olditem[0]))
                    {
                        input.Insert(index + 1, olditem[1]);
                    }

                }
                else if (splited[0] == "Renew")
                {
                    if (input.Contains(splited[1]))
                    {
                        string item = splited[1];
                        input.Remove(item);
                        input.Add(item);
                    }
                }
                comanded = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
