using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "M.Hamza Naeem";


            //Change text Color

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //app info
            Console.WriteLine("{0}: Version{1} by {2}", appName, appVersion, appAuthor);



            //Reset Console Color
            Console.ResetColor();

            //Ask user name
            Console.WriteLine("Write is your name?");

            //Get User input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);

            while (true)
            {

                //Init Correct number
                //int correctNumber = 7;

                //Create a new Random object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);




                //Init guess var
                int guess = 0;
                //Ask User for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Tell user its not a number
                        Console.WriteLine("Please enter an actual number");

                        //Reset text color
                        Console.ResetColor();

                        //Keep going to tell user to continue
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match Guess to correct number
                    if (guess != correctNumber)
                    {

                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Wrong # info Alert
                        Console.WriteLine("Wrong number, please try again");

                        //Reset text color
                        Console.ResetColor();





                    }

                }
                //Change text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                //tell user its correct number
                Console.WriteLine("Hurry!!!..You are CORRECT");

                //Reset Text Color
                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Play Again?[Y or N]");

                //Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue; }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

                Console.ReadLine();
            }

        }
    }
}
