using System;

namespace Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputNum = Console.ReadLine();
            
            for (int i = inputNum.Length; i > 0; i--)
            {
                for (int j = inputNum.Length; j > 0; j--)
                {
                    for (int k = inputNum.Length; k > 0; k--)
                    {
                        int sum = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {sum};");
                    }
                }
            }



            
        }
    }
}
