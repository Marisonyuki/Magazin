using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    internal static class Log
    {
        public static void LogInit()
        {
            Console.WriteLine("Войдите в ваш аккаунт");
            Console.WriteLine("  Логин: ");
            Console.WriteLine("  Пароль: ");
            Console.WriteLine("  Авторизоваться:");
        }
        public static string LogUsername()
        {
            string username = Console.ReadLine();
            return username;
        }
        public static int LogPassword()
        {
            int pass = Convert.ToInt32(Console.ReadLine());
            return pass;
        }

        public static int LogCheck(Account Kassir, Account Sklad, string UserCheck, int PassCheck)
        {
            int Logger = 0;
            if (UserCheck == Kassir.Login && PassCheck == Kassir.Password)
            {
                Logger = 1;
            }
            if (UserCheck == Sklad.Login && PassCheck == Sklad.Password)
            {
                Logger = 2;
            }
            return Logger;
        }
    }
}
