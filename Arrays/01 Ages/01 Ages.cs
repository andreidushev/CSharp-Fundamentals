using System;

namespace _01_Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string person = string.Empty;

            if (input <= 2)
            {
                person = "baby";
            }
            else if (input <= 13)
            {
                person = "child";
            }
            else if (input <= 19)
            {
                person = "teenager";
            }
            else if (input <= 65)
            {
                person = "adult";
            }
            else
            {
                person = "elder";
            }

            Console.WriteLine(person);
        }
    }
}
