using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            PrintAgeAfter10Years(n);
            List<int> list = new List<int>();

        }
        static List<int> ReadList(int n)
        {
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            return list;
        }
        static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        static void PrintAgeAfter10Years(int age)
        {
            age += 10;
            Console.WriteLine(age);
        }
    }
}

