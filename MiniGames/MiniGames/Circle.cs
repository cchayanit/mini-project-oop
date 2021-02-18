using System;


namespace MiniGames
{
    class Circle
    {
        private double radius;
        private double thickness = 0.5;
        private char symbol = '+';

        public void Playcir()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nWelcome to the create circle game \n");
            Console.ResetColor();

            do
            {
                Console.Write("Enter radius = ");

                if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                //If the input is not a double then it will iterate again
                //If the input is a double but is <= 0 it will iterate again.
                {
                    Console.WriteLine("radius have to be positive number");
                }
            }
            while (radius <= 0);
           

            double rIn = radius - thickness;
            double rOut = radius + thickness;

            for (double y = radius; y >= -radius; y--)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut) 
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Thanks for playing");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
