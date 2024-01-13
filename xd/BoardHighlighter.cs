using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class BoardHighlighter
    {
        public static int[] Highlight(List<string> seatList)
        {
            int[] number = new int[] { 0, 0 };
            ExitTheCinema.ChangeConsoleColorToBlackAndClear();
            View.DrawBoard(seatList);
            Console.WriteLine("\nAby wrócić do menu głównego wciśnij escape");
            Console.SetCursorPosition(0, 0);
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow: MoveAndColor.MoveUpAndColor(Cinema.y.Length, seatList); break;
                    case ConsoleKey.DownArrow: MoveAndColor.MoveDownAndColor(Cinema.y.Length, seatList); break;
                    case ConsoleKey.RightArrow: MoveAndColor.MoveRightAndColor(Cinema.x.Length, seatList); break;
                    case ConsoleKey.LeftArrow: MoveAndColor.MoveLeftAndColor(Cinema.x.Length, seatList); break;
                    case ConsoleKey.Enter: number = new int[] { (Console.CursorLeft < 4) ? Console.CursorLeft : (Console.CursorLeft > 4 && Console.CursorLeft < 9) ? Console.CursorLeft - 1 : Console.CursorLeft - 2, Console.CursorTop }; break;
                    case ConsoleKey.Escape: number = new int[] { -1, -1 }; break;
                }
            } while (key != ConsoleKey.Enter && key != ConsoleKey.Escape);
            return number;
        }
    }
}
