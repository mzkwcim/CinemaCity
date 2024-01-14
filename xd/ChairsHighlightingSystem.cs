using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class ChairsHighlightingSystem
    {
        public static int[] HighlightACertainPlaceOnBoard()
        {
            int[] number = new int[] { 0, 0 };
            ExitingSystem.ChangeConsoleColorToBlackAndClear();
            DisplaySystem.DrawBoard();
            Console.WriteLine("\nAby wrócić do menu głównego wciśnij escape");
            Console.SetCursorPosition(0, 0);
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow: MoveAndColor.MoveUpAndColor(); break;
                    case ConsoleKey.DownArrow: MoveAndColor.MoveDownAndColor(); break;
                    case ConsoleKey.RightArrow: MoveAndColor.MoveRightAndColor(); break;
                    case ConsoleKey.LeftArrow: MoveAndColor.MoveLeftAndColor(); break;
                    case ConsoleKey.Enter: number = new int[] { (Console.CursorLeft < 4) ? Console.CursorLeft : (Console.CursorLeft > 4 && Console.CursorLeft < 9) ? Console.CursorLeft - 1 : Console.CursorLeft - 2, Console.CursorTop }; break;
                    case ConsoleKey.Escape: number = new int[] { -1, -1 }; break;
                }
            } while (key != ConsoleKey.Enter && key != ConsoleKey.Escape);
            return number;
        }
    }
}
