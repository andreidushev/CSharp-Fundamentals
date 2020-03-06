using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int daysasnum = int.Parse(Console.ReadLine());

            if (daysasnum >=1 && daysasnum <=7)
            {
                Console.WriteLine(days[daysasnum - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
