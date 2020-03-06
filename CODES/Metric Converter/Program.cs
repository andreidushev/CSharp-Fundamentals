using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());
            string textin = Console.ReadLine();
            string textout = Console.ReadLine();

            if (textin == "mm")
            {
                num/= 1000;
            }
            else if (textin == "cm")
            {
                num/= 100;
            }
            if (textout == "mm")
            {
                num*= 1000;
            }
            else if (textout == "cm")
            {
                num*= 100;
            }
            Console.WriteLine($"{num:F3}");
        }    
    }
}
