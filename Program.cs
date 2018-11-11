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

            Console.WriteLine("{0}: Version {1} by {2} (credits to: {3})", appName,appVersion,appAuthor,coAuthor);

            //reset color
            Console.ResetColor();

            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...",input);
        }
    }
}
