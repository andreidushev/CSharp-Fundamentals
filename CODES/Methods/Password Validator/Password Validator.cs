using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            if (!HowLong(pass))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!IsLetterOrDigit(pass))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!HasTwoDigits(pass))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (HasTwoDigits(pass) && HowLong(pass) && IsLetterOrDigit(pass))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool HowLong(string pass)
        {
            return pass.Length >= 6 && pass.Length <= 10;
        }

        static bool IsLetterOrDigit(string pass)
        {
            foreach (char symbol in pass)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        static bool HasTwoDigits(string pass)
        {
            int digitCounter = 0;

            foreach (char symbol in pass)
            {
                if (char.IsDigit(symbol))
                {
                    digitCounter++;
                }
            }

            return digitCounter >= 2;
        }
    }
}
