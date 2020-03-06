using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lootChest = Console.ReadLine().Split('|').ToList();

            string argument = Console.ReadLine();

            while (argument !="Yohoho")
            {
                string[] comand = argument.Split();

                if (comand[0] == "Loot")
                {
                    for (int i = int.Parse(comand[1]); i < comand.Length; i++)
                    {
                        if (!lootChest.Contains(comand[i]))
                        {
                            lootChest.IndexOf(comand[i]);
                        }
                    }
                }
                if (comand[0] == "Drop")
                {
                    int index = int.Parse(comand[1]);

                    if (index > 0 && index < lootChest.Count)
                    {
                        string treasure = lootChest[index];
                        lootChest.RemoveAt(index);
                        lootChest.Add(treasure);
                    }
                }
                if (comand[0] == "Steal")
                {
                    int count = int.Parse(comand[1]);

                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(string.Join(",",i));
                        int last = lootChest.Count - 1;
                        lootChest.RemoveAt(last);
                    }
                }
            }
        }
    }
}
