using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    internal class TovarOptions
    {
        public static List<Tovar> SaveTovars = new List<Tovar>();

        public static Tovar TovarSave()
        {
            SaveTovars = SaveTovars.ToList();
            Tovar Box = new Tovar();
            Box.TName = "Коробки";
            Box.TValue = 10.01;
            Box.TAmount = 10;
            SaveTovars.Add(Box);
            return Box;
        }
    }
}
