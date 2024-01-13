using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class MoveAndColor
    {
        public static void MoveUpAndColor(int y, List<string> seatList)
        {
            ColorABoard.UnColor(Console.CursorLeft, Console.CursorTop, seatList);
            MoveCursorOnBoard.MoveUp(y);
            ColorABoard.Color(Console.CursorLeft, Console.CursorTop, seatList);
        }
        public static void MoveDownAndColor(int y, List<string> seatList)
        {
            ColorABoard.UnColor(Console.CursorLeft, Console.CursorTop, seatList);
            MoveCursorOnBoard.MoveDown(y);
            ColorABoard.Color(Console.CursorLeft, Console.CursorTop, seatList);
        }
        public static void MoveRightAndColor(int x, List<string> seatList)
        {
            ColorABoard.UnColor(Console.CursorLeft, Console.CursorTop, seatList);
            MoveCursorOnBoard.MoveRight(x);
            ColorABoard.Color(Console.CursorLeft % (x + 2), Console.CursorTop, seatList);
        }
        public static void MoveLeftAndColor(int x, List<string> seatList)
        {
            ColorABoard.UnColor(Console.CursorLeft, Console.CursorTop, seatList);
            MoveCursorOnBoard.MoveLeft(x);
            ColorABoard.Color(Console.CursorLeft % (x + 2), Console.CursorTop, seatList);
        }
    }
}
