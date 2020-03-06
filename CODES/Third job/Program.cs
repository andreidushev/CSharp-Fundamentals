using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_job
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double Lengh = Math.Abs(x1 - x2);
            double Widht = Math.Abs(y1 - y2);
            double area = Lengh * Widht;
            double perimeter = 2 * (Lengh + Widht);
            Console.WriteLine($"{area:F2} USD. ");
            Console.WriteLine($"{perimeter:F2} BGN.");
        }
    }
}
