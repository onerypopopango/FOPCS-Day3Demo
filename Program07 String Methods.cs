using System;

namespace Day3
{
    class Prog7
    {
        public static void Main(string[] args)
        {
            string s = "$$$*******%%%%%***abcde$$$%%% ******";
            char[] c = new char[] { '$', '*' };

            string r = s.Trim(c);                       //learn how Trim works

            Console.WriteLine(s);
            Console.WriteLine(r);

            Console.WriteLine();

            string t = "ABC";
            string u = t.PadLeft(7, ' '); 
            Console.WriteLine(t);
            Console.WriteLine(u);
            Console.WriteLine(t.PadRight(6, '@'));      //pad left/right

            Console.WriteLine();

            string v = "Venkat";
            string w = v.ToUpper(); 
            Console.WriteLine(v); 
            Console.WriteLine(w); 
            Console.WriteLine(v.ToLower());             //to upper/lower


            Console.WriteLine();

            int i;
            string a = "Institute of Systems Science"; 
            string[] b = a.Split(' ');
            for (i = 0; i <= b.Length - 1; i++)
            {
                Console.WriteLine(b[i]);                //split into array
            }

        }
    }
}
