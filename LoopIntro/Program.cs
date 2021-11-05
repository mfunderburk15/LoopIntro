using System;

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

            string name = "John Smith";
            
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }
            
            /*
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            */
        }
    }
}
