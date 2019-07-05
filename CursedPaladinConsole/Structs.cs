using System;

namespace CursedPaladinConsole
{
    struct LI_Console
    {
        public int Id;
        public string Name;
        public IConsoleWindow ConsoleWindow;

        public LI_Console(int _id, string _name, IConsoleWindow _consoleWindow)
        {
            Id = _id;
            Name = _name;
            ConsoleWindow = _consoleWindow;
        }
    }



}