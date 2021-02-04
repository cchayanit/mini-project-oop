using System;

namespace MiniGames
{
	class Program
	{

		static void Main(string[] args)
		{
			

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("...........................");
			Console.WriteLine("           @@@      ");
			Console.WriteLine("         @ + + @    ");
			Console.WriteLine("            @       ");
			Console.WriteLine("           @@@      WELCOME TO MINIGAMES ");
			Console.WriteLine("          @ @ @  @  by chayanit chookul");
			Console.WriteLine("         @  @  @@   ");
			Console.WriteLine("            @       ");
			Console.WriteLine("           @ @      ");
			Console.WriteLine("          @   @     ");
			Console.WriteLine("..........................");
			Console.ResetColor();

			Menu theGame = new Menu();
			theGame.MainStart();

							
		}

	}

}




			

