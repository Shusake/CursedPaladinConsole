using System;

namespace CursedPaladinConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Game cursed = new Game(80, 45, "CursedPaladin");
            cursed.Run();
        }
    }
}
