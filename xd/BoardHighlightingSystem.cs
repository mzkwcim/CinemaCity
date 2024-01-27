using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class BoardHighlightingSystem
    {
        public static void ColorABoard(int x, int y, ListManager listManager)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(listManager.seatList[(y * listManager.seatList.Count / Cinema.y.Length) + ((x < 4) ? x : (x > 4 && x < 9) ? x - 1 : x - 2)]);
            Console.SetCursorPosition(x, y);
        }
        public static void UnColorABoard(int x, int y, ListManager listManager)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(listManager.seatList[(y * listManager.seatList.Count / Cinema.y.Length) + ((x < 4) ? x : (x > 4 && x < 9) ? x - 1 : x - 2)]);
            Console.SetCursorPosition(x, y);
        }
        public static void Color(int tokenToDetectList)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write((tokenToDetectList == 1) ? Cinema.menu[Console.CursorTop] : ExitingSystem.response[Console.CursorTop]);
        }
        public static void UnColor(int tokenToDetectList)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write((tokenToDetectList == 1) ? Cinema.menu[Console.CursorTop] : ExitingSystem.response[Console.CursorTop]);
        }
    }
}
