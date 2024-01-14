using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class MenuTrafficControllSystem
    {
        public static void MoveUp(int tokenToDetectList)
        {
            if (tokenToDetectList == 0)
            {
                Console.CursorTop = (Console.CursorTop - 1 < 1) ? ExitingSystem.response.Length - 1 : (Console.CursorTop - 1) % ExitingSystem.response.Length;
            }
            else
            {
                Console.CursorTop = (Console.CursorTop - 1 < 1) ? Cinema.menu.Length - 1 : (Console.CursorTop - 1) % Cinema.menu.Length;
            }

        }
        public static void MoveDown(int tokenToDetectList)
        {
            if (tokenToDetectList == 0)
            {
                Console.CursorTop = ((Console.CursorTop + 1) % ExitingSystem.response.Length == 0) ? 1 : (Console.CursorTop + 1) % ExitingSystem.response.Length;
            }
            else
            {
                Console.CursorTop = ((Console.CursorTop + 1) % Cinema.menu.Length == 0) ? 1 : (Console.CursorTop + 1) % Cinema.menu.Length;
            }
            
        }
        public static void MoveUpAndColor(int tokenToDetectList)
        {
            BoardHighlightingSystem.UnColor(tokenToDetectList);
            MoveUp(tokenToDetectList);
            BoardHighlightingSystem.Color(tokenToDetectList);
        }
        public static void MoveDownAndColor(int tokenToDetectList)
        {
            BoardHighlightingSystem.UnColor(tokenToDetectList);
            MoveDown(tokenToDetectList);
            BoardHighlightingSystem.Color(tokenToDetectList);
        }
    }
}
