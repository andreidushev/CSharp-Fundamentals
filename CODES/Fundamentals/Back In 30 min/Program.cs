using System;

namespace Back_In_30_min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours -= 24;
            }
            string output = $"{hours}:{minutes:D2}";
            Console.WriteLine(output);
        }
    }
}
