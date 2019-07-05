using System;


namespace CursedPaladinConsole
{
    class SplashWindow : IConsoleWindow
    {
        public void Flush()
        {
            Console.CursorLeft = (Console.WindowWidth / 2) - 15;
            Console.CursorTop = (Console.WindowHeight / 2) - 1;

            Console.Write("Welcome to ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\"Cursed Paladin\"");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("!");

            Console.CursorLeft = (Console.WindowWidth / 2) - 15;
            Console.CursorTop = (Console.WindowHeight / 2) + 1;

            Console.Write("Roguelike game by Nakano Ren");

            Console.CursorLeft = (Console.WindowWidth / 2) - 12;
            Console.CursorTop = (Console.WindowHeight / 2) + 6;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("...Press any key...");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Clear()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for (int x = 0; x < Console.WindowWidth; x++)
                for (int y = 0; y < Console.WindowHeight; y++)
                {
                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                    Console.Write(" ");
                }
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
        }
    }
}
