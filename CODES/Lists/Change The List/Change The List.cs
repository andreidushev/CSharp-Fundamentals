using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_The_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line =="end")
                {
                    break;
                }

                string[] nums = line.Split();
                string comand = nums[0];
                int element = int.Parse(nums[1]);

                if (comand == "Delete")
                {
                    numbers.RemoveAll(x => x == element);
                }
                else if (comand == "Insert")
                {
                    int index = int.Parse(nums[2]);
                    numbers.Insert(index, element);

                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
