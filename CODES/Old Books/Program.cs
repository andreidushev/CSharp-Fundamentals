using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int numBooks = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isBook = false;

            string books = Console.ReadLine();

            while (counter < numBooks)
            {
                if (books == bookName)
                {
                    isBook = true;
                    break;
                }
                counter++;
                books = Console.ReadLine();
            }
            if (isBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {numBooks} books.");
            }
        }
    }
}
