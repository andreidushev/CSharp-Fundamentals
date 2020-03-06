using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            double minValue = int.MaxValue;

            while (counter < n)
            {
                double num = double.Parse(Console.ReadLine());

                if (minValue > num)
                {
                    minValue = num;
                }
                counter++;
            }
            Console.WriteLine(minValue);
        }
    }
}
