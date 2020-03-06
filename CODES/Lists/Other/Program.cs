using System;
using System.Collections.Generic;
using System.Linq;

namespace Other
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ReadList();

            for (int i = 0; i < list.Count/2; i++)
            {
                Console.WriteLine(list[i] + list[list.Count -1-i]);

            }

            Console.WriteLine(string.Join(" , ",list));

            static void PrintList(List<int> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            
            static List<int> ReadList()
            {
                List<int> list = new List<int>();
                string[] elements = Console.ReadLine().Split();
                for (int i = 0; i < elements.Length; i++)
                {
                    list.Add(int.Parse(elements[i]));
                }
                return list;
            }

            static List<int> ReadLis(int n)
            {
                var list = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    list.Add(int.Parse(Console.ReadLine()));
                }
                return list;
            }
        }
    }
}
