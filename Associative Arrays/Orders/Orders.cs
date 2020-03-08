using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productsPrice = new Dictionary<string, decimal>();
            Dictionary<string, long> productsQuantitys = new Dictionary<string, long>();

            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] productsArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = productsArgs[0];
                decimal price = decimal.Parse(productsArgs[1]);
                int quantity = int.Parse(productsArgs[2]);

                if (!productsQuantitys.ContainsKey(name))
                {
                    productsQuantitys[name] = 0;
                    productsPrice[name] = 0m;
                }
                productsQuantitys[name] += quantity;
                productsPrice[name] = price;
            }
            foreach (var item in productsPrice)
            {
                string name = item.Key;
                decimal price = item.Value;
                long quantity = productsQuantitys[name];
                decimal totalPrice = price * quantity;
                Console.WriteLine($"{name} -> {totalPrice}");
            }
            
        }
    }
}
