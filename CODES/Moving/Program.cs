using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widh = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int totalRoom = widh * lenght * hight;
            int boxes = 0;
            string input = Console.ReadLine();

            while (input != "Done")
            {
                int box = int.Parse(input);
                boxes += box;

                if (boxes > totalRoom)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (boxes > totalRoom)
            {
                int roomNeed = boxes - totalRoom;
                Console.WriteLine($"No more free space! You need {roomNeed} Cubic meters more.");
            }
            else
            {
                int Room = totalRoom - boxes;
                Console.WriteLine($"{Room} Cubic meters left.");
            }
        }
    }
}
