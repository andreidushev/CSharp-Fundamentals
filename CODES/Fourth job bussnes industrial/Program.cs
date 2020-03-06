using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_job_bussnes_industrial
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());
            double areaOneCover = tables * (lenght + 2 * 0.30) * (widht + 2 * 0.30);
            double areaOneSquare = tables * (lenght / 2) * (lenght / 2);
            double totalPriceInDollars = areaOneCover * 7 + areaOneSquare * 9;
            double totalPriceInBGN = totalPriceInDollars * 1.85;
            Console.WriteLine($"{totalPriceInDollars:F2} USD ");
            Console.WriteLine($"{totalPriceInBGN:F2} BGN ");



        }
    }
}
