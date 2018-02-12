using System;
using System.Threading;

namespace Day3
{
    class Prog3
    {
        static void Main(string[] args)
        {
            //repeat i from 1 to 7
            for (int i = 1; i <= 7; i++)
            {
                //draw * i times

                //repeat j from 1 to i
                for (int j = 1; j <= i; j++)
                {
                    //print * horizontally
                    Console.Write("*");
                }

                //change to new line
                Console.WriteLine();
            }

        }
    }
}
