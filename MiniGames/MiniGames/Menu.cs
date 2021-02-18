using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGames
{
    class Menu
    {
        private void MainText()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nplease select the game\n");
            Console.WriteLine("1. guessing game");
            Console.WriteLine("2. create circle game");
            Console.WriteLine("3. Exit");
            Console.WriteLine("\n");
            Console.ResetColor();
        }
        public void MainStart()
        {
            string choice ;
            do
            {
                MainText();
                Console.WriteLine("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Guessnum theGuess = new Guessnum();
                        theGuess.Playguess();
                        break;
                    case "2":
                        Circle theCircle = new Circle();
                        theCircle.Playcir();
                        break;
                }
            } while (choice != "3" );
        }
        
    }
}

