﻿using System;

namespace LoopIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            /*
            for (int i = 1; i <= 10; i++)
            {
                if ( i % 2 ==0 )
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            //string name = "John Smith";

            //foreach (char letter in name)
            //{
            //    Console.WriteLine(letter);
            //}

            /*
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            */

            //int[] numbers = new int[] { 1, 2, 3, 4 };
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            while(true)
            {
                Console.Write("Type your name: ");
                string input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                Console.WriteLine("@Echo: " + input);
            }
        }
    }
}
