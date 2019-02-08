using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter
{
    class Program
    {
        static void Main(string[] args)
        {
            //take in information for the sender and recipiant
            Console.WriteLine("What color would you like the background? (Blue, Green, Yellow)");

            string Background = Console.ReadLine();

            Console.WriteLine("What color would you like the foreground to be? (White, Black, Magenta)");

            string Foreground = Console.ReadLine();

            if (Background == "Blue"  && Foreground == "White")
            { 

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

            }
            if (Background == "Blue" && Foreground == "Black")
            {

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;


            }
            if (Background == "Blue" && Foreground == "Magenta")
            {



                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Magenta;


            }

            if (Background == "Green" && Foreground == "White")
            {


                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;


            }
            if (Background == "Green" && Foreground == "Black")
            {



                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (Background == "Green" && Foreground == "Magenta")
            {


                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            if (Background == "Yellow" && Foreground == "White")
            {

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.White;


            }
            if (Background == "Yellow" && Foreground == "Black")
            {

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;


            }
            if (Background == "Yellow" && Foreground == "Magenta")
            {


                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Magenta;


            }



            // Ask user for their name 
            Console.WriteLine("What is the sender's first and last name?");

            string _sendername = Console.ReadLine();


            // Ask user for their address

            Console.WriteLine("What is the sender's street address");

            string _senderaddress = Console.ReadLine();

            Console.WriteLine("What is the sneder's city, state zip code?");

            string _sendercity = Console.ReadLine();



            //aske for the recipiant's inforamtion here

            Console.WriteLine("What is the recipiant's first and last name?");

           string _recipiantname = Console.ReadLine();

            Console.WriteLine("What is the recipiant's street address?");

            string _recipiantaddress = Console.ReadLine();

            Console.WriteLine("What is te recipiant's city, state zip code?");

            string _recipiantcity = Console.ReadLine();

            Console.Clear();

                    //put in the recipiant information and have it centered here

            int leftOffSet = (Console.WindowWidth / 2);
            int topOffSet = (Console.WindowHeight / 2);



            //Console.SetCursorPosition(leftOffSet, topOffSet);

            Console.WriteLine("");

            Console.WriteLine("{0}", _sendername);

            //Console.SetCursorPosition(leftOffSet, topOffSet);

            Console.WriteLine(_senderaddress);

            //Console.SetCursorPosition(leftOffSet, topOffSet);

            Console.WriteLine(_sendercity);

            Console.WriteLine("");

            Console.WriteLine("");

            //Console.ReadLine();
            topOffSet = topOffSet + 10;
            //  Console.SetCursorPosition(leftOffSet, topOffSet);
            

            Console.WriteLine("               {0}", _recipiantname);
            Console.WriteLine("               {0}", _recipiantaddress);
            Console.WriteLine("               {0}",  _recipiantcity);

            Console.Read();

        }
    }//hello
}
