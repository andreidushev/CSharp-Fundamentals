using System;

namespace Coins_
{
    class Program
    {
        static void Main(string[] args)
        {
            double coins = double.Parse(Console.ReadLine());
            double lf = Math.Floor(coins);
            double stotinki = Math.Round((coins - lf) * 100);
            double broq = 0;

            while (lf > 0)
            {
                if (lf >= 2)
                {
                    broq += 1;
                    lf -= 2;
                }
                else if (lf >= 1)
                {
                    broq += 1;
                    lf -= 1;
                }
            }
            while (stotinki > 0)
            {
                if (stotinki >= 50)
                {
                    broq += 1;
                    stotinki -= 50;
                }
                else if (stotinki >= 20)
                {
                    broq += 1;
                    stotinki -= 20;
                }
                else if (stotinki >= 10)
                {
                    broq += 1;
                    stotinki -= 10;
                }
                else if (stotinki >= 05)
                {
                    broq += 1;
                    stotinki -= 05;
                }
                else if (stotinki >= 02)
                {
                    broq += 1;
                    stotinki -= 02;
                }
                else if (stotinki >= 01)
                {
                    broq += 1;
                    stotinki -= 01;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(broq);
        }
    }
}
