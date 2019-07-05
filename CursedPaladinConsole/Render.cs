using System;
using System.Collections.Generic;

namespace CursedPaladinConsole
{
    class Render
    {
        // Members
        private List<LI_Console> m_Consoles;
        private int m_CurConsoleId;

        // Functions

        public Render(int _width, int _height)
        {
            Console.WindowWidth = _width;
            Console.WindowHeight = _height;
            Console.BufferWidth = _width;
            Console.BufferHeight = _height;

            Console.CursorVisible = false;
            Console.CursorLeft = 0;
            Console.CursorTop = 0;

            m_Consoles = new List<LI_Console>();

            AddConsole("Splash", new SplashWindow());
            ChangeConsoleTo("Splash");
        }

        public void Flush()
        {
            m_Consoles[m_CurConsoleId].ConsoleWindow.Flush();
        }

        private void AddConsole(string _name, IConsoleWindow _consoleWindow)
        {
            m_Consoles.Add(new LI_Console(m_Consoles.Count, _name, _consoleWindow));
        }

        private void ChangeConsoleTo(int _id)
        {
            foreach (LI_Console item in m_Consoles)
            {
                if(item.Id == _id)
                {
                    m_CurConsoleId = item.Id;
                    item.ConsoleWindow.Clear();
                    break;
                }
            }
        }

        private void ChangeConsoleTo(string _name)
        {
            foreach (LI_Console item in m_Consoles)
            {
                if (item.Name == _name)
                {
                    m_CurConsoleId = item.Id;
                    item.ConsoleWindow.Clear();
                    break;
                }
            }
        }
    }
}

/*
 * Task.Factory.StartNew(() =>
 *          {
 *              while (Console.ReadKey().Key != ConsoleKey.Q) ;
 *              exit = true;
 *          });
 *
 *      while (!exit)
 *      {
 *          // Do stuff
 *      }
 */
