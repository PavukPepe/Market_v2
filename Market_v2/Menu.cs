using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_v2
{
    internal class Menu
    {
        private int minstr;
        private int maxstr;


        public Menu(int min, int max)
        {
            maxstr = max;
            minstr = min;
        }

        public int Show()
        {
            int pos = 1;
            ConsoleKey key;

            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey().Key;

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key == ConsoleKey.DownArrow && pos != maxstr)
                    pos++;
                else if (key == ConsoleKey.UpArrow && pos != minstr)
                    pos--;
                else if (key == ConsoleKey.Escape)
                    return 404;

            } while (key != ConsoleKey.Enter);

            return pos;
        }
    }
}
