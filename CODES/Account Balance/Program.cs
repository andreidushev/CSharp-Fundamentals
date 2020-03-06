using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double currentDeposit = 0;
            double total = 0;

            

            while (currentDeposit < count)
            {
                double deposit = double.Parse(Console.ReadLine());

                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                
                Console.WriteLine($"Increase: {deposit:F2}");
                currentDeposit++;
                total += deposit;
            }
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
