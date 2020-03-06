using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            string comand;

            while ((comand=Console.ReadLine()) !="End")
            {
                string[] cmdArgs = comand
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string cmdType = cmdArgs[0];
                if (cmdType =="Add")
                {
                    AddNumber(numbers, cmdArgs);
                }
                else if (cmdType =="Insert")
                {
                    InsertIndex(numbers, cmdArgs);

                }
                else if (cmdType == "Remove")
                {
                    RemoveIndex(numbers, cmdArgs);
                }
                else if (cmdType == "Shift")
                {
                    Shift(numbers, cmdArgs);
                }
            }

            Console.WriteLine(String.Join(" ",numbers));
        }

        private static void Shift(List<int> numbers, string[] cmdArgs)
        {
            string directions = cmdArgs[1];
            int count = int.Parse(cmdArgs[2]);

            count = count % numbers.Count;

            if (directions == "left")
            {
                ShiftLeft(numbers, count);
            }
            else if (directions == "right")
            {
                ShiftRight(numbers, count);
            }
        }

        private static void ShiftRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastElement = numbers[numbers.Count - 1];

                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastElement);
            }
        }

        private static void ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstElement = numbers[0];

                numbers.RemoveAt(0);
                numbers.Add(firstElement);
            }
        }

        private static void RemoveIndex(List<int> numbers, string[] cmdArgs)
        {
            int index = int.Parse(cmdArgs[1]);
            if (index >= 0 && index < numbers.Count)
            {
                numbers.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        private static void InsertIndex(List<int> numbers, string[] cmdArgs)
        {
            int num = int.Parse(cmdArgs[1]);
            int index = int.Parse(cmdArgs[2]);

            if (index >= 0 && index < numbers.Count)
            {
                numbers.Insert(index, num);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        private static void AddNumber(List<int> numbers, string[] cmdArgs)
        {
            int num = int.Parse(cmdArgs[1]);
            numbers.Add(num);
        }
    }
}
