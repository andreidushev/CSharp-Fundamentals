using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceSkumriaKg = double.Parse(Console.ReadLine());
            double priceCacaiaKg = double.Parse(Console.ReadLine());
            double palamudKG = double.Parse(Console.ReadLine());
            double safridKG = double.Parse(Console.ReadLine());
            double midiKG = double.Parse(Console.ReadLine());

            double pricePalamudKg = priceSkumriaKg + (priceSkumriaKg * 0.60);
            double priceSafridKg = priceCacaiaKg + (priceCacaiaKg * 0.80);
            double sumMidiKg = midiKG * 7.50;

            double sumPalamud = palamudKG * pricePalamudKg;
            double sumSafrid = safridKG * priceSafridKg;

            double totalSum = sumPalamud + sumSafrid + sumMidiKg;
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
