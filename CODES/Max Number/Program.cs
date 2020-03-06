using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double counter = 0;
            double max = int.MinValue;

            while (counter < n)
            {
                double num = double.Parse(Console.ReadLine());
                

                if (max < num)
                {
                    max = num;
                }
                counter++;
            }
            Console.WriteLine(max);
        }
    }
}
