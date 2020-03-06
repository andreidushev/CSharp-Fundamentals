using System;

namespace Sample_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyFoodPerDay = int.Parse(Console.ReadLine());
            int moneySouvenirsPerDay = int.Parse(Console.ReadLine());
            int moneyHotelPerDay = int.Parse(Console.ReadLine());

            double distance = 210 * 2;
            int tripTime = 3;
            double carPetrol = 7;
            double pricePetrol = 1.85;

            double needPetrol =(distance / 100 ) * carPetrol;
            double moneyPetrol = needPetrol * pricePetrol;
            double otherMoney = (moneyFoodPerDay * tripTime) + (moneySouvenirsPerDay * tripTime);

            double firstDay = moneyHotelPerDay * 0.9;
            double secondDay = moneyHotelPerDay * 0.85;
            double thirdDay = moneyHotelPerDay * 0.8;

            double totalMoney = moneyPetrol + otherMoney + firstDay + secondDay + thirdDay;
            Console.WriteLine($"Money needed: {totalMoney:F2}");
            

            

        }
    }
}
