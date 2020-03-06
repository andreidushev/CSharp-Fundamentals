using System;
using System.Collections.Generic;
using System.Linq;

namespace Friend_List_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friendsList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int blackList = 0;
            int lostList = 0;


            

            while (true)
            {
                string[] comands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                string command = comands[0];

                if (command == "Report")
                {
                    break;
                }
                if (command == "Blacklist")
                {
                    string name = comands[1];
                    if (friendsList.Contains(name))
                    {
                        int index = friendsList.IndexOf(name);
                        Console.WriteLine($"{name} was blacklisted.");
                        friendsList.Remove(name);
                        friendsList.Insert(index, "Blacklisted");
                        blackList++;
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (command == "Error")
                {
                    int index = int.Parse(comands[1]);
                    string name = friendsList[index];
                    if (name !="Blacklisted" && name != "Lost")
                    {
                        friendsList.Remove(name);
                        friendsList.Insert(index, "Lost");
                        lostList++;
                        Console.WriteLine($"{name} was lost due to an error.");
                    }
                }
                else if (command == "Change")
                {
                    int index = int.Parse(comands[1]);
                    string newname = comands[2];
                    if (index >= 0 && index <= friendsList.Count)
                    {
                        string currentName = friendsList[index];
                        friendsList.Remove(currentName);
                        friendsList.Insert(index, newname);
                        Console.WriteLine($"{currentName} changed his username to {newname}.");
                    }

                }
            }
            Console.WriteLine($"Blacklisted names: {blackList}");
            Console.WriteLine($"Lost names: {lostList}");
            Console.WriteLine(string.Join(" ", friendsList));
        }
    }
}
