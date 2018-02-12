using System;
using System.Threading;

namespace Day3
{
    class Prog2
    {
        public static void Main(string[] args)
        {
            //a program that asks for password
            //the password is ISS
            //if the person gives wrong password 3 times
            //the system locksdown

            int seconds = 2000;             //timing for thread.sleep

            bool correctpass = false;       //int boolean as flag

            //repeat 3 times
            for (int i = 0; i < 3; i++)     //alt: for (int i = 1; i <= 3; i++)
            {
                //  ask for password
                Console.Write("Enter Password: ");
                string input = Console.ReadLine();

                //  if password correct
                if (input == "ISS")
                {
                    //      set the flag to true to prevent the 'locked out'
                    correctpass = true;
                    //      say Congrats
                    Console.WriteLine("Congratulations. Welcome to ISS.");
                    //      exit repetition
                    break;       
                }

                //  else
                else
                {
                    //      say Password Incorrect
                    Console.WriteLine("Password Incorrect.\n");
                }

            }

            Thread.Sleep(seconds);
            //write 'locked out msg' for more than 3 attmepts
            if (!correctpass)                   //(correctpass == false)  <== for simplicity's sake
            {
                Console.WriteLine("You have been locked out. Goodbye.");
            }


        }
    }
}
