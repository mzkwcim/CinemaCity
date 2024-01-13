using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class BoardTrafficControlSystem
    {
        public static void MoveUp(int y) => Console.CursorTop = (Console.CursorTop - 1 < 0) ? (y - 1) : (Console.CursorTop - 1) % y;
        public static void MoveDown(int y) => Console.CursorTop = (Console.CursorTop + 1 > y) ? 0 : (Console.CursorTop + 1) % y;
        public static void MoveLeft(int x) => Console.CursorLeft = (Console.CursorLeft - 1 < 0) ? x + 1 : (Console.CursorLeft - 1 == 4 || Console.CursorLeft - 1 == 9) ? (Console.CursorLeft - 2) % (x + 2) : (Console.CursorLeft - 1) % (x + 2);
        public static void MoveRight(int x) => Console.CursorLeft = (Console.CursorLeft + 1 > x + 1) ? 0 : (Console.CursorLeft + 1 == 4 || Console.CursorLeft + 1 == 9) ? (Console.CursorLeft + 2) % (x + 2) : (Console.CursorLeft + 1) % (x + 2);
    }
}
