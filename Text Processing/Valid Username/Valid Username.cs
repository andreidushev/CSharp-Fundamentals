using System;
using System.Linq;

namespace Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.None).ToArray();

            foreach (var username in userNames)
            {
                if (ValidUserName(username))
                {
                    Console.WriteLine(username);
                }
            }
        }
        private static bool ValidUserName(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }
            bool isValid = true;

            for (int i = 0; i < username.Length; i++)
            {
                char currentChar = username[i];

                if (!(Char.IsLetterOrDigit(currentChar) || currentChar == '-' || currentChar == '_'))
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }

    }
}
