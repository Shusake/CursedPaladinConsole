using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursedPaladinConsole
{
    class Keyboard
    {
        public delegate void KeyInput();

        public event KeyInput KeyDown;

        public void Input()
        {
            if (Console.KeyAvailable)
                Console.ReadKey();
        }
    }
}
