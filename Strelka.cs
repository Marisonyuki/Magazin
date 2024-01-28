using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    internal class Strelka
    {
        public static int Show(int StrelkaPos)
        {
            int pos = 1;
            int maxpos = StrelkaPos;
            ConsoleKeyInfo skey = Console.ReadKey();
            while (skey.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                skey = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (skey.Key == ConsoleKey.UpArrow && pos != 1)
                {
                    pos--;
                }
                if (skey.Key == ConsoleKey.DownArrow && pos != maxpos)
                {
                    pos++;
                }
            }
            return pos;
        }
    }
}
