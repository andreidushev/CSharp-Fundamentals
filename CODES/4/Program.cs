using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("HELLO");
            Console.WriteLine(".");
            Console.Write("NAME?:  ");
            String name = Console.ReadLine();
            Console.Write("HI,  ");
            Console.Write(name);
            Console.WriteLine("!");
            {
                Console.Write("Age:");
                String age = Console.ReadLine();
                Console.Write("Your Age is,");
                Console.WriteLine(age);
                {
                    Console.Write(" FROM?:");
                    String car = Console.ReadLine();
                    Console.Write("You are from,");
                    Console.WriteLine(car);
                    {
                        Console.Write("Lubim cvqt ?:");
                        String color = Console.ReadLine();
                        Console.Write("Vie obichate,  ");
                        Console.WriteLine(color);
                        {
                            Console.Write("Ot kade ste?:");
                            String city = Console.ReadLine();
                            Console.Write("Vie ste ot,  ");
                            Console.WriteLine(city);
                        }
                    }

                }
            }
        }
    }
}
