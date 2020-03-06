using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            if (list[0] == list[0 + 1])
            {
                list[0] += list[0 + 1];
                list.RemoveAt(0 + 1);

            }

            Console.WriteLine(string.Join(" , ",list));
        }
    }
}
