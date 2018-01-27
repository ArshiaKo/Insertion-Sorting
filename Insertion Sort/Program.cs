﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            bool DevelopeMode = false;
            int[] ints = new int[10];
            #region Ask for 10 numbers
            if (DevelopeMode)
            {
                Console.WriteLine("Give me 10 numbers");
                for (int i = 0; i < 10; i++)
                {
                    char num = Console.ReadKey().KeyChar;
                    Console.WriteLine("");
                    if (num != '1' && num != '2' && num != '3' && num != '4' && num != '5' && num != '6' && num != '7' && num != '8' && num != '9' && num != '0')
                    {
                        Console.WriteLine("I eat numbers, not letters");
                    }
                    else
                    {
                        ints[i] = int.Parse(num.ToString());
                    }
                }
            }
            #endregion
            #region Random
            Random rand = new Random(1);
            if (!DevelopeMode)
            {
                for (int i = 0; i < 10; i++)
                {
                    ints[i] = rand.Next(1, 11);

                    Console.WriteLine(ints[i]);
                }
            }
            #endregion
            Console.ReadKey();
        }
    }
}
//3 2 5 8 7 5 4 10 2 7
//2 2 3 4 5 5 7 7 8 10