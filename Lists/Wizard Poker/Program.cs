using System;
using System.Collections.Generic;
using System.Linq;

namespace Wizard_Poker
{
    class Program
    {
        static void Main()
        {
            List<string> availableCards = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> newCardList = new List<string>();
            List<string> result = new List<string>();

            

            while (commands[0] != "Ready")
            {
                switch (commands[0])
                {
                    case "Add": AddCard(newCardList, commands[1], availableCards, result); break;
                    case "Insert": InsertCard(newCardList, commands[1], int.Parse(commands[2]), availableCards, result); break;
                    case "Remove": RemoveCard(newCardList, commands[1], result); break;
                    case "Swap": SwapCards(newCardList, commands[1], commands[2]); break;
                    case "Shuffle": newCardList.Reverse(); ; break;
                    default:
                        break;
                }

                commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

            Console.WriteLine(String.Join(" ", newCardList));
        }

        static void AddCard(List<string> newDeck, string card, List<string> availables, List<string> result)
        {
            if (availables.Contains(card) )
            {
                newDeck.Add(card);
            }
            else
            {
                result.Add("Card not found.");
            }
        }
        
        static void InsertCard(List<string> newDeck, string card, int position, List<string> availables, List<string> result)
        {
            if (availables.Contains(card) )
            {
                newDeck.Insert(position, card);
            }
            else
            {
                result.Add("Error!");
            }
        }
        
        static void RemoveCard(List<string> newDeck, string card, List<string> result)
        {
            if (newDeck.Contains(card) )
            {
                newDeck.Remove(card);
            }
            else
            {
                result.Add("Card not found.");
            }
        }
        
        static void SwapCards(List<string> newDeck, string card1, string card2)
        {
            int indexC1 = newDeck.IndexOf(card1);
            int indexC2 = newDeck.IndexOf(card2);

            newDeck[indexC1] = card2;
            newDeck[indexC2] = card1;
        }
        
        //static void ShuffleDeck(List<string> newDeck)
        //{
            
        //}

    }
}
