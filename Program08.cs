using System;

namespace Day3
{
    class Prog8
    {
        public static void Main(string[] args)
        {
            string s = "Hello world!";
            string r = "";


            //to print each character on a single line


            //repeat i from 0 to the (length of s -1)
            for (int i = 0; i <= s.Length - 1; i++)
            {
                //print the i-th character of s
                Console.WriteLine(s.Substring(i, 1));
            }

            Console.WriteLine();

            //to reverse string...
            for (int i = s.Length - 1; i >= 0; i--)
            {
                string x = s.Substring(i, 1);

                //if the i-th character is not blank, then print
                if (x != " ")
                {
                    Console.WriteLine(x);
                    r = r + x;
                }
            }

            Console.WriteLine(r);       //putting reversed items into new string
        }
    }
}
