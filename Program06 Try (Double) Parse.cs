using System;
using System.Threading;

namespace Day3
{
    class Prog6a
    {
        public static void Main(string[] args)
        {
            double length;
            bool successfulParse;

            do
            {
                Console.Write("Enter a length in cm: ");
                //length = Double.Parse(Console.ReadLine());

                string input = Console.ReadLine();
                successfulParse = Double.TryParse(input, out length);      //tryparse thingy

            }
            while ((length < 0) || (successfulParse == false));            //condition length negative or parse fails causes loop

            double inch = length / 2.54;

            Console.WriteLine("The length in inch is {0:0.00}", inch);
        }
    }
}
