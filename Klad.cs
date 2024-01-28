using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    internal class Klad : ICRUD
    {
        public static void Menu()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            int StrelkaPos = 1;
            while (key.Key != ConsoleKey.Escape)
            {
                Strelka.Show(StrelkaPos);

            }
            Program.Main();
        }

        public void Create()
        {

        }
        public void Read()
        {

        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
    }
}
