using System;

namespace Time__15_mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes >= 60 && hour < 23)
            {
                minutes -= 60;
                hour = hour + 1;
            }
            else if (minutes >= 60 && hour == 23)
            {
                minutes -= 60;
                hour = 0;
            }
            
            Console.WriteLine($"{hour}:{minutes:d2}");

        }
    }
}
