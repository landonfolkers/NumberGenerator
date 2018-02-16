using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            getAppInfo();

            greetUser();

            while (true)
            {

                //int correctNumber = 5;

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {

                        printColor(ConsoleColor.Red, "Please select an actual number.");


                        continue;
                    }


                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {

                        printColor(ConsoleColor.Magenta, "Wrong! Please try again.");
                    }

                }

                printColor(ConsoleColor.DarkGreen, "That is CORRECT!");

                Console.WriteLine("Play again [Y or No]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }    
            }
        }

        static void getAppInfo () {
            string appName = "Number Generator";
            string appVersion = "1.0.0";
            string appAuthor = "Landon Folkers";

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void greetUser() {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void printColor(ConsoleColor color, string message) {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
