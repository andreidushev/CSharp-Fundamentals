﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> charList
                = Console.ReadLine().ToCharArray().ToList();

            int explosion = 0;

            for (int i = 0; i < charList.Count - 1; i++)
            {
                char temp = charList[i];

                if (temp == '>')
                {

                    for (int c = i; c < charList.Count - 1; c++) 
                    {

                        if (charList[c] == '>' && int.TryParse(charList[c + 1].ToString(), out int b) == true)
                        {
                            explosion = explosion + int.Parse(charList[c + 1].ToString());

                        }

                        if (charList[c] != '>')
                        {

                            if (c <= charList.Count - 1)
                            {

                                charList.RemoveAt(c);
                                c--;
                                
                            }
                            explosion--;

                            if (charList[c + 1] == '>' && explosion > 0)
                            {
                                i += 1;
                            }

                            if (explosion == 0)
                            {

                                break;
                            }
                        }
                    }
                }

                if (explosion > 0)
                {

                    charList.RemoveAt(charList.Count - 1);

                }

            }
            Console.WriteLine(string.Join(string.Empty, charList));
        }
    }
}
