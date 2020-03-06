using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] bombNum = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int bomb = bombNum[0];
            int power = bombNum[1];

            while (true)
            {
                int indexBombNum = numbers.IndexOf(bomb);
                int numbersCount = numbers.Count;

                if (indexBombNum == -1)
                {
                    break;
                }

                int rightIndex = indexBombNum + power;

                for (int i = indexBombNum; i <= rightIndex; i++)
                {
                    if (i < numbersCount)
                    {
                        numbers.RemoveAt(indexBombNum);
                    }
                    else
                    {
                        break;
                    }
                }

                int leftIndex = indexBombNum - power;

                for (int i = indexBombNum - 1; i >= leftIndex; i--)
                {
                    if (i >= 0)
                    {
                        numbers.RemoveAt(i);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
