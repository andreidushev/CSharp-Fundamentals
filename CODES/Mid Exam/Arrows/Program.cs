﻿using System;
using System.Linq;

namespace Arrows
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split('|').Select(int.Parse).ToArray();

            string input = Console.ReadLine();
            int points = 0;

            while (input != "Game over")
            {
                string[] splited = input.Split();

                if (splited[0] == "Reverse")
                {
                    targets=targets.Reverse().ToArray();
                }

                if (splited[0] == "Shoot")
                {
                    string[] shooting = splited[1].Split('@');

                    if (shooting[0] == "Left")
                    {
                        int index = int.Parse(shooting[1]);
                        int count = int.Parse(shooting[2]);
                        if (index >= 0 && index < targets.Length)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                index--;
                                if (index == -1)
                                {
                                    index = targets.Length - 1;
                                }
                            }
                            if (targets[index] >= 5)
                            {
                                targets[index] -= 5;
                                points += 5;
                            }
                            else if (targets[index] > 0)
                            {
                                points += targets[index];
                                targets[index] = 0;
                            }
                        }
                    }
                    if (shooting[0] == "Right")
                    {
                        int index = int.Parse(shooting[1]);
                        int count = int.Parse(shooting[2]);
                        if (index >= 0 && index < targets.Length)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                index++;
                                if (index == targets.Length)
                                {
                                    index = 0;
                                }
                            }
                            if (targets[index] >= 5)
                            {
                                targets[index] -= 5;
                                points += 5;
                            }
                            else if (targets[index] > 0)
                            {
                                points += targets[index];
                                targets[index] = 0;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" - ", targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}
