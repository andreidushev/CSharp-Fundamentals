using System;

namespace Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string correct = string.Empty;

            for (int i = username.Length -1; i >= 0; i--)
            {
                correct += username[i];
            }

            bool blocked = true;

            for (int i = 0; i < 3; i++)
            {
                string pass = Console.ReadLine();

                if (correct == pass)
                {
                    blocked = false;
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

            if (blocked)
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
