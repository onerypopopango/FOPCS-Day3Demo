using System;

namespace Day3
{
    class Prog1
    {
        public static void Main(string[] args)
        {
            //counting starting from 0 in variable i, each time increased by i
            //while i < 10
            //we want i to go from 0 .. 9

            for (int i = 10; i <= 15; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            for (int j = 20; j >= 10; j--)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("");

            for (int k = 0; k <= 10; k += 2)    //k increases at an interval of 2
            {
                Console.WriteLine(k);
            }
        }
    }
}
