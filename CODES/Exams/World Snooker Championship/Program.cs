using System;

namespace World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string etap = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int ticketNum = int.Parse(Console.ReadLine());
            string photo = Console.ReadLine();
            double ticketPrice = 0;

            if (typeTicket == "Standard")
            {
                if (etap == "Quarter final")
                {
                    ticketPrice = 55.50;
                }
                else if (etap == "Semi final")
                {
                    ticketPrice = 75.88;
                }
                else if (etap == "final")
                {
                    ticketPrice = 110.10;
                }
            }
            else if (typeTicket == "Premium")
            {
                if (etap == "Quarter final")
                {
                    ticketPrice = 105.20;
                }
                else if (etap == "Semi final")
                {
                    ticketPrice = 125.22;
                }
                else if (etap == "final")
                {
                    ticketPrice = 160.66;
                }
            }
            else if (typeTicket == "VIP")
            {
                if (etap == "Quarter final")
                {
                    ticketPrice = 118.90;
                }
                else if (etap == "Semi final")
                {
                    ticketPrice = 300.40;
                }
                else if (etap == "final")
                {
                    ticketPrice = 400;
                }
            }



            double totalPrice = ticketPrice * ticketNum;

            if (totalPrice > 2500 && totalPrice <= 4000)
            {
                totalPrice *= 0.9;
                if (photo == "Y")
                {
                    totalPrice += 40 * ticketNum;
                }
            }
            else if (totalPrice > 4000)
            {
                totalPrice *= 0.75;
            }
            else
            {
                if (photo == "Y")
                {
                    totalPrice += 40 * ticketNum;

                }
            }
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
