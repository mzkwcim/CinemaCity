using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class MoveAndColor
    {
        public static void MoveUpAndColor()
        {
            BoardHighlightingSystem.UnColorABoard(Console.CursorLeft, Console.CursorTop);
            BoardTrafficControlSystem.MoveUp();
            BoardHighlightingSystem.ColorABoard(Console.CursorLeft, Console.CursorTop);
        }
        public static void MoveDownAndColor()
        {
            BoardHighlightingSystem.UnColorABoard(Console.CursorLeft, Console.CursorTop);
            BoardTrafficControlSystem.MoveDown();
            BoardHighlightingSystem.ColorABoard(Console.CursorLeft, Console.CursorTop);
        }
        public static void MoveRightAndColor()
        {
            BoardHighlightingSystem.UnColorABoard(Console.CursorLeft, Console.CursorTop);
            BoardTrafficControlSystem.MoveRight();
            BoardHighlightingSystem.ColorABoard(Console.CursorLeft % (Cinema.x.Length + 2), Console.CursorTop);
        }
        public static void MoveLeftAndColor()
        {
            BoardHighlightingSystem.UnColorABoard(Console.CursorLeft, Console.CursorTop);
            BoardTrafficControlSystem.MoveLeft();
            BoardHighlightingSystem.ColorABoard(Console.CursorLeft % (Cinema.x.Length + 2), Console.CursorTop);
        }
    }
}
