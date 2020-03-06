using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnum = int.Parse(Console.ReadLine());
            int secondnum = int.Parse(Console.ReadLine());

            if (firstnum > secondnum)
            {
                Console.WriteLine(firstnum);
            }
            else
            {
                Console.WriteLine(secondnum);
            }
        }
    }
}
