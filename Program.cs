using System;


namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", inputName);

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
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Enter a NUMBER!");
                        Console.ResetColor();
                        continue;
                    }
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, try again!");
                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("CORRECT!");
                Console.ResetColor();

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
    }
}
