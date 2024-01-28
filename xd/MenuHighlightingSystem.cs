using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class MenuHighlightingSystem
    {
        public static int HighlightACertainOption()
        {
            int number = 1;
            ConsoleKey key;
            DisplaySystem.Menu();
            Console.SetCursorPosition(0, 1);
            int tokenToDetectList = 1;
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
