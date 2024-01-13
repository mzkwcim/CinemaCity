using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class MenuTrafficControllSystem
    {
        public static void MoveUp(string[] menu) => Console.CursorTop = (Console.CursorTop - 1 < 1) ? menu.Length - 1 : (Console.CursorTop - 1) % menu.Length;
        public static void MoveDown(string[] menu) => Console.CursorTop = ((Console.CursorTop + 1) % menu.Length == 0) ? 1 : (Console.CursorTop + 1) % menu.Length;
        public static void MoveUpAndColor(string[] menu)
        {
            MenuHighlight.UnColor(menu);
            MoveUp(menu);
            MenuHighlight.Color(menu);
        }
        public static void MoveDownAndColor(string[] menu)
        {
            MenuHighlight.UnColor(menu);
            MoveDown(menu);
            MenuHighlight.Color(menu);
        }
    }
}
