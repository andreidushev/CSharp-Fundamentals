using System;

namespace Tax_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerEngine = int.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            string ecoStandard = Console.ReadLine();

            while (powerEngine <= 37)
            {
                if (city == "Sofia")
                {
                    double price = powerEngine * 1.43;

                    if (ecoStandard == "Euro 4")
                    {
                        price -= price * 0.15;
                    }
                    else if (ecoStandard == "Euro 5")
                    {
                        price -= price * 0.17;
                    }
                    else if (ecoStandard == "Euro 6")
                    {
                        price -= price * 0.20;
                    }
                    Console.WriteLine($"{price:F2} lv");
                    break;
                }
                else if (city == "Vidin")
                {
                    double price = powerEngine * 1.34;
                    if (ecoStandard == "Euro 4")
                    {
                        price -= price * 0.15;
                    }
                    else if (ecoStandard == "Euro 5")
                    {
                        price -= price * 0.17;
                    }
                    else if (ecoStandard == "Euro 6")
                    {
                        price -= price * 0.20;
                    }
                    Console.WriteLine($"{price:F2} lv");
                    break;
                }
                else if (city == "Varna")
                {
                    double price = powerEngine * 1.37;
                    if (ecoStandard == "Euro 4")
                    {
                        price -= price * 0.15;
                    }
                    else if (ecoStandard == "Euro 5")
                    {
                        price -= price * 0.17;
                    }
                    else if (ecoStandard == "Euro 6")
                    {
                        price -= price * 0.20;
                    }
                    Console.WriteLine($"{price:F2} lv");
                    break;
                }
            }
            while (powerEngine >= 38 && powerEngine <= 55)
            {
                if (city == "Sofia")
                {
                    double price = powerEngine * 1.50;

                    if (ecoStandard == "Euro 4")
                    {
                        price -= price * 0.15;
                    }
                    else if (ecoStandard == "Euro 5")
                    {
                        price -= price * 0.17;
                    }
                    else if (ecoStandard == "Euro 6")
                    {
                        price -= price * 0.20;
                    }
                    Console.WriteLine($"{price:F2} lv");
                    break;
                }
                else if (city == "Vidin")
                {
                    double price = powerEngine * 1.40;
                    if (ecoStandard == "Euro 4")
                    {
                        price -= price * 0.15;
                    }
                    else if (ecoStandard == "Euro 5")
                    {
                        price -= price * 0.17;
                    }
                    else if (ecoStandard == "Euro 6")
                    {
                        price -= price * 0.20;
                    }
                    Console.WriteLine($"{price:F2} lv");
                    break;
                }
                else if (city == "Varna")
                {
                    double price = powerEngine * 1.40;
                    if (ecoStandard == "Euro 4")
                    {
                        price -= price * 0.15;
                    }
                    else if (ecoStandard == "Euro 5")
                    {
                        price -= price * 0.17;
                    }
                    else if (ecoStandard == "Euro 6")
                    {
                        price -= price * 0.20;
                    }
                    Console.WriteLine($"{price:F2} lv");
                    break;
                }
            }
            while (powerEngine > 55)
            {
                if (city == "Sofia")
                {
                    double price = powerEngine * 2.68;

                    if (ecoStandard == "Euro 4")
                    {
                        price -= price * 0.15;
                    }
                    else if (ecoStandard == "Euro 5")
                    {
                        price -= price * 0.17;
                    }
                    else if (ecoStandard == "Euro 6")
                    {
                        price -= price * 0.20;
                    }
                    Console.WriteLine($"{price:F2} lv");
                    break;
                }
                else if (city == "Vidin")
                {
                    double price = powerEngine * 2.54;
                    if (ecoStandard == "Euro 4")
                    {
                        price -= price * 0.15;
                    }
                    else if (ecoStandard == "Euro 5")
                    {
                        price -= price * 0.17;
                    }
                    else if (ecoStandard == "Euro 6")
                    {
                        price -= price * 0.20;
                    }
                    Console.WriteLine($"{price:F2} lv");
                    break;
                }
                else if (city == "Varna")
                {
                    double price = powerEngine * 2.57;
                    if (ecoStandard == "Euro 4")
                    {
                        price -= price * 0.15;
                    }
                    else if (ecoStandard == "Euro 5")
                    {
                        price -= price * 0.17;
                    }
                    else if (ecoStandard == "Euro 6")
                    {
                        price -= price * 0.20;
                    }
                    Console.WriteLine($"{price:F2} lv");
                    break;
                }
            }
        }
    }
}
