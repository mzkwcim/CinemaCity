using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class MenuHighlight
    {
        public static int Highlight(string[] menu)
        {
            int number = 1;
            ConsoleKey key;
            DisplaySystem.Menu(menu);
            Console.SetCursorPosition(0, 1);
            do
            {
                Console.CursorVisible = false;
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow: MenuTrafficControllSystem.MoveUpAndColor(menu); break;
                    case ConsoleKey.DownArrow: MenuTrafficControllSystem.MoveDownAndColor(menu); break;
                    case ConsoleKey.Enter: number = Console.CursorTop; break;
                }
            } while (key != ConsoleKey.Enter);
            return number;
        }
        public static void Color(string[] menu)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(menu[Console.CursorTop]);
        }
        public static void UnColor(string[] menu)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(menu[Console.CursorTop]);
        }
    }
}
