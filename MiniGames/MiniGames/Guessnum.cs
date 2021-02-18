using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGames
{
	class Guessnum
	{
		public static int targetNumber; 
		public static int guess;
		
		public void Playguess()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nWelcome to the number guessing game \n");
			Console.ResetColor();
			Console.WriteLine("Put your number please...\n");

			targetNumber = ThinkOfNewNumber();

		
			int noOfGuesses = 0;

			while (guess != targetNumber)
			{
				Console.WriteLine("Guess number " + (noOfGuesses += 1));
				Int32.TryParse(Console.ReadLine(), out guess); 
				
				bool guessIsValid = IsGuessValid(); 

				if (!guessIsValid)  // >100 or <0  -->return false -->true
				{
					Console.WriteLine("Please try again.");
					IsGuessValid();
				}

				IsNumberCorrect();

			}
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("Thanks for playing");
			Console.ResetColor();
			Console.ReadKey();
		}

		static int ThinkOfNewNumber() 
		{
			Random rnd = new Random();
			return rnd.Next(0,100); 
		}

		static bool IsGuessValid()
		{
			if (guess > 100)
			{
				Console.WriteLine("Guess must be less than or equal to 100\n");
				return false;
			}
			else if (guess < 0)
			{
				Console.WriteLine("Guess must be greater than or equal to 0\n");
				return false;
			}

			return true;
		}

		static void IsNumberCorrect()
		{
			if (guess == targetNumber)
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("\n!!!!!!!You win !!!!!!!\n");
			}
			else if (guess > targetNumber && guess <= 100)
			{
				Console.WriteLine("Too High\n");
			}
			else if (guess < targetNumber && guess >= 0)
			{
				Console.WriteLine("Too Low\n");
			}
		}

	}
}
