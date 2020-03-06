using System;

namespace Number_Seaquence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minNUMBER = int.MaxValue;
            int maxNUMBER = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxNUMBER)
                {
                    maxNUMBER = currentNumber;
                }
                if (currentNumber < minNUMBER)
                {
                    minNUMBER = currentNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNUMBER}");
            Console.WriteLine($"Min number: {minNUMBER}");

        }
    }
}
