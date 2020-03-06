﻿using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int savedMoney = 0;
            int presentMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    presentMoney += 10;
                    savedMoney += presentMoney;
                    savedMoney--;
                }
                else
                {
                    savedMoney += toyPrice;
                }
            }
            if (savedMoney >= washingMachine)
            {
                Console.WriteLine($"Yes! {savedMoney - washingMachine:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - savedMoney:F2}");
            }
        }
    }
}
