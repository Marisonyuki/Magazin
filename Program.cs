using System.Security.Principal;

namespace Magazin
{
    internal class Program
    {
        public static void Main()
        {
            Account Kassir = new Account();
            Kassir.Login = "Kassir";
            Kassir.Password = 123;

            Account Sklad = new Account();
            Sklad.Login = "Sklad";
            Sklad.Password = 123;

            Console.WriteLine("Нажмите Escape чтобы выйти или любую кнопку чтобы продолжить");

            int RolePick = Authentication(Kassir, Sklad);

            if (RolePick == 1)
            {
                Kass.Menu();
            }
            if (RolePick == 2)
            {
                Klad.Menu();
            }
        }

        static int Authentication(Account Kassir, Account Sklad)
        {
            int role = 0;
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            Log.LogInit();
            string UserCheck = "";
            int PassCheck = 0;
            int StrelkaPos = 3;
            while (key.Key != ConsoleKey.Escape)
            {
                int option = Strelka.Show(StrelkaPos);
                if (option == 1)
                {
                    Console.SetCursorPosition(10, 1);
                    UserCheck = Log.LogUsername();
                }
                if (option == 2)
                {
                    Console.SetCursorPosition(11, 2);
                    PassCheck = Log.LogPassword();
                }
                if (option  == 3)
                {
                    Console.Clear();
                    int LogTrue = Log.LogCheck(Kassir, Sklad, UserCheck, PassCheck);
                    if (LogTrue == 0)
                    {
                        Log.LogInit();
                    }
                    if (LogTrue == 1)
                    {
                        role = 1;
                        break;
                    }
                    if (LogTrue == 2)
                    {
                        role = 2;
                        break;
                    }
                }
            }
            if (key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Environment.Exit(0);
            }
            return role;
        }
    }
}