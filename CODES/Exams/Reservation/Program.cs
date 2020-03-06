using System;

namespace Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayReservation = int.Parse(Console.ReadLine());  
            int monthReservation = int.Parse(Console.ReadLine()); 
            int dayStay = int.Parse(Console.ReadLine()); 
            int monthStay = int.Parse(Console.ReadLine()); 
            int dayLeft = int.Parse(Console.ReadLine()); 
            int monthLeft = int.Parse(Console.ReadLine()); 

            double priceForStay = (dayLeft - dayStay) * 30;
            double dayPeriod = dayStay - dayReservation;

            if (dayPeriod < 10)
            {
                priceForStay = (dayLeft - dayStay) * 30;
            }
            else if (monthReservation < monthStay)
            {
                priceForStay = ((dayLeft - dayStay) * 25) * 0.20;
            }
            Console.WriteLine($"Your stay from {dayStay}/{monthStay} to {dayLeft}/{monthLeft} will cost {priceForStay:F2}");
            
        }
    }
}
