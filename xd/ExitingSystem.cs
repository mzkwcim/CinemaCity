using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    
    class ExitingSystem
    {
        internal static string[] response = new string[] { "Czy na pewno chcesz wyjść z kina?", "Nie", "Tak" };
        public static bool ExitACinema()
        {
            ChangeConsoleColorToBlackAndClear();
            if (DoYouRealyWantToExitACinema() == 1)
            {
                ChangeConsoleColorToBlackAndClear();
                return true;
            }
            else
            {
                ChangeConsoleColorToBlackAndClear();
                Console.WriteLine("Dziękujemy za wizytę w kinie");
                return false;
            }
        }
        public static void ChangeConsoleColorToBlackAndClear()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }
        public static int DoYouRealyWantToExitACinema()
        {
            int number = 1;
            Console.WriteLine($"{response[0]}\n{response[1]}\n{response[2]}");
            ConsoleKey key;
            Console.SetCursorPosition(0, 1);
            int tokenToDetectList = 0;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow: MenuTrafficControllSystem.MoveUpAndColor(tokenToDetectList); break;
                    case ConsoleKey.DownArrow: MenuTrafficControllSystem.MoveDownAndColor(tokenToDetectList); break;
                    case ConsoleKey.Enter: number = Console.CursorTop; break;
                }
            } while (key != ConsoleKey.Enter);
            return number;
        }
    }
}
