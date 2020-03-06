using System;
using System.Collections.Generic;
using System.Linq;

namespace Weaposmith
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] weaponParts = Console.ReadLine().Split('|');

            string comand = Console.ReadLine();

            while (comand != "Done")
            {
                string[] splited = comand.Split(" ");

                if (splited[0] == "Check")
                {
                    int sign = 0;
                    if (splited[1] == "Odd")
                    {
                        sign = 1;
                    }
                    for (int i = 0; i < weaponParts.Length; i++)
                    {
                        if (i % 2 == sign)
                        {
                            Console.Write(weaponParts[i] + " ");
                        }
                    }
                    Console.WriteLine("");
                }
                if (splited[0] == "Move")
                {
                    if (splited[1] == "Left")
                    {
                        int index = int.Parse(splited[2]);

                        if (index > 0 && index < weaponParts.Length)
                        {
                            string temp = weaponParts[index];
                            weaponParts[index] = weaponParts[index - 1];
                            weaponParts[index - 1] = temp;
                        }
                    }
                    if (splited[1] == "Right")
                    {
                        int index = int.Parse(splited[2]);

                        if (index >= 0 && index < weaponParts.Length - 1)
                        {
                            string temp = weaponParts[index];
                            weaponParts[index] = weaponParts[index + 1];
                            weaponParts[index + 1] = temp;
                        }
                    }
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"You crafted {string.Join("",weaponParts)}!");
        }
    }
}
