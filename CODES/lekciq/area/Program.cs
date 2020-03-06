using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int time = num * 3;

            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.",name, time, num );
        }
    }
}
