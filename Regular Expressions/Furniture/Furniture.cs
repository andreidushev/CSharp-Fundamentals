using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Furniture
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quant>\d+)";

            string input = Console.ReadLine();

            var items = new List<string>();
            double totalPrice = 0;

            while (input !="Purchase")
            {
                MatchCollection match = Regex.Matches(input, pattern);

                foreach (Match m in match)
                {
                    var name = m.Groups["name"].Value;
                    var price = double.Parse(m.Groups["price"].Value);
                    var quant = int.Parse(m.Groups["quant"].Value);

                    items.Add(name);
                    totalPrice += price * quant;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Bought furniture:");
            if (items.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, items)}");
            }
            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
