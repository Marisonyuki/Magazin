using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    internal static class Kass
    {
        public static void Menu()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine("Товары");
            int Strelkapos = 1;
            Tovar Tovar1 = TovarOptions.TovarSave();
            while (key.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("  " + Tovar1.TName + " " + Tovar1.TValue + " " + Tovar1.TAmount);
                Strelka.Show(Strelkapos);
                while (key.Key != ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("Выбранный товар: " + Tovar1.TName);
                    Console.WriteLine("  " + Tovar1.TName + " " + Tovar1.TValue + " " + Tovar1.TAmount);
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("Сумма заказа: " + (Tovar1.TValue*(Tovar1.TAmount-10))*(-1));
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.A && Tovar1.TAmount != 10)
                    {
                        Tovar1.TAmount++;
                    }
                    if (key.Key == ConsoleKey.D && Tovar1.TAmount != 0)
                    {
                        Tovar1.TAmount--;
                    }
                }
            }
        }
    }
}
