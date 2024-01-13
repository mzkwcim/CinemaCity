using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class ExitTheCinema
    {
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
            string[] response = new string[] { "Czy na pewno chcesz wyjść z kina?", "Nie", "Tak" };
            Console.WriteLine($"{response[0]}\n{response[1]}\n{response[2]}");
            ConsoleKey key;
            Console.SetCursorPosition(0, 1);
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow: MoveCursorOnMenu.MoveUpAndColor(response); break;
                    case ConsoleKey.DownArrow: MoveCursorOnMenu.MoveDownAndColor(response); break;
                    case ConsoleKey.Enter: number = Console.CursorTop; break;
                }
            } while (key != ConsoleKey.Enter);
            return number;
        }
    }
}
