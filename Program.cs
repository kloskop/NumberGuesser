using System;


namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {
                //int correctNumber = 7;
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.DarkYellow,"Input a NUMBER!");
                        continue;
                    }
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.DarkRed, "Wrong number, try again!");
                    }
                }
                PrintColorMessage(ConsoleColor.Green, "You are CORRECT!");

                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer =="Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Kloskop";
            string coAuthor = "Brad Traversy";
            //setup text color
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("{0}: Version {1} by {2} (credits to: {3})", appName, appVersion, appAuthor, coAuthor);
            //reset color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
