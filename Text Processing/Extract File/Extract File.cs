using System;
using System.Linq;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Console.ReadLine();

            string[] path = directory.Split('\\',StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] file = path.Last().Split('.',StringSplitOptions.RemoveEmptyEntries).ToArray();

            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}
