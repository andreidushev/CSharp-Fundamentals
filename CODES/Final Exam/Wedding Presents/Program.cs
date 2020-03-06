using System;

namespace Wedding_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfQuests = double.Parse(Console.ReadLine());
            double numberOfPresents = double.Parse(Console.ReadLine());

            double counterA = 0;
            double counterB = 0;
            double counterV = 0;
            double counterG = 0;

            

            for (int i = 0; i <= numberOfPresents; i++)
            {
                string present = Console.ReadLine();
                if (present == "A")
                {
                    counterA++;
                    
                    
                }
                else if (present == "B")
                {
                    counterB++;
                    
                    
                }
                else if (present == "V")
                {
                    counterV++;
                    
                    
                }
                else if (present == "G")
                {
                    counterG++;
                    
                    
                }
            }
            double porcentA = (counterA / numberOfPresents) * 100;
            double porcentB = (counterB / numberOfPresents) * 100;
            double porcentV = (counterV / numberOfPresents) * 100;
            double porcentG = (counterG / numberOfPresents) * 100;

            Console.WriteLine($"{porcentA:F2}%");
            Console.WriteLine($"{porcentB:F2}%");
            Console.WriteLine($"{porcentV:F2}%");
            Console.WriteLine($"{porcentG:F2}%");
            double totalPorcent = (numberOfPresents / numberOfQuests) * 100;
            Console.WriteLine($"{totalPorcent:F2}%");
        }
    }
}
