using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(':').ToList();

            List<string> deck = new List<string>();

            string comand = Console.ReadLine();

            while (comand != "Ready")
            {
                string[] splited = comand.Split(" ");

                switch (splited[0])
                {
                    case "Add":
                        {
                            if (cards.Contains(splited[1]))
                            {
                                deck.Add(splited[1]);
                            }
                            else
                            {
                                Console.WriteLine("Card not found.");
                            }
                        };
                        break;
                    case "Insert":
                        {
                            string cardname = splited[1];
                            int index = int.Parse(splited[2]);

                            if (index < 0 || index > deck.Count || cards.IndexOf(cardname) == -1)
                            {
                                Console.WriteLine("Error!");
                            }
                            else
                            {
                                deck.Insert(index, cardname);
                            }
                        };
                        break;
                    case "Remove":
                        {
                            if (deck.Contains(splited[1]))
                            {
                                deck.Remove(splited[1]);
                            }
                            else
                            {
                                Console.WriteLine("Card not found.");
                            }
                        };
                        break;
                    case "Swap":
                        {
                            int firstCard = deck.IndexOf(splited[1]);
                            int secondCard = deck.IndexOf(splited[2]);

                            string temp = deck[firstCard];
                            deck[firstCard] = deck[secondCard];
                            deck[secondCard] = temp;

                        };
                        break;
                    case "Shuffle":
                        {
                            deck.Reverse();
                        };
                        break;

                }

                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",deck));
        }

    }
}
