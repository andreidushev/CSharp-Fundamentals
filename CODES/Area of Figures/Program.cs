using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double num = double.Parse(Console.ReadLine());
                double area = num * num;
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "rectangle")
            {
                double num = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double area = num * num2;
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "circle")
            {
                double num = double.Parse(Console.ReadLine());
                double area = (Math.PI * num * num);
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "triangle")
            {
                double num = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double area = num * num2 / 2;
                Console.WriteLine($"{area:F3}");
            }
        }
    }
}
