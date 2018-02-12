using System;
using System.Threading;

namespace Day3
{
    class Prog6
    {
        public static void Main(string[] args)
        {
            double length;

            do
            {
                Console.Write("Enter a length in cm: ");
                length = Double.Parse(Console.ReadLine());
            }
            while (length < 0);

            double inch = length / 2.54;

            Console.WriteLine("The length in inch is {0:0.00}", inch);
        }
    }
}
