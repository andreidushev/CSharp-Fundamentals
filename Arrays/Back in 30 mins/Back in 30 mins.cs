using System;

namespace Back_in_30_mins
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
