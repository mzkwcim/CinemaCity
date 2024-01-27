using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class MoveAndColor
    {
        public static void MoveUpAndColor(ListManager listManager)
        {
            BoardHighlightingSystem.UnColorABoard(Console.CursorLeft, Console.CursorTop, listManager);
            BoardTrafficControlSystem.MoveUp();
            BoardHighlightingSystem.ColorABoard(Console.CursorLeft, Console.CursorTop, listManager);
        }
        public static void MoveDownAndColor(ListManager listManager)
        {
            BoardHighlightingSystem.UnColorABoard(Console.CursorLeft, Console.CursorTop, listManager);
            BoardTrafficControlSystem.MoveDown();
            BoardHighlightingSystem.ColorABoard(Console.CursorLeft, Console.CursorTop, listManager);
        }
        public static void MoveRightAndColor(ListManager listManager)
        {
            BoardHighlightingSystem.UnColorABoard(Console.CursorLeft, Console.CursorTop, listManager);
            BoardTrafficControlSystem.MoveRight();
            BoardHighlightingSystem.ColorABoard(Console.CursorLeft % (Cinema.x.Length + 2), Console.CursorTop, listManager);
        }
        public static void MoveLeftAndColor(ListManager listManager)
        {
            BoardHighlightingSystem.UnColorABoard(Console.CursorLeft, Console.CursorTop, listManager);
            BoardTrafficControlSystem.MoveLeft();
            BoardHighlightingSystem.ColorABoard(Console.CursorLeft % (Cinema.x.Length + 2), Console.CursorTop, listManager);
        }
    }
}
