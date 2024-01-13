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
            BoardColoringSystem.UnColor(Console.CursorLeft, Console.CursorTop, seatList);
            BoardTrafficControlSystem.MoveUp(y);
            BoardColoringSystem.Color(Console.CursorLeft, Console.CursorTop, seatList);
        }
        public static void MoveDownAndColor(int y, List<string> seatList)
        {
            BoardColoringSystem.UnColor(Console.CursorLeft, Console.CursorTop, seatList);
            BoardTrafficControlSystem.MoveDown(y);
            BoardColoringSystem.Color(Console.CursorLeft, Console.CursorTop, seatList);
        }
        public static void MoveRightAndColor(int x, List<string> seatList)
        {
            BoardColoringSystem.UnColor(Console.CursorLeft, Console.CursorTop, seatList);
            BoardTrafficControlSystem.MoveRight(x);
            BoardColoringSystem.Color(Console.CursorLeft % (x + 2), Console.CursorTop, seatList);
        }
        public static void MoveLeftAndColor(int x, List<string> seatList)
        {
            BoardColoringSystem.UnColor(Console.CursorLeft, Console.CursorTop, seatList);
            BoardTrafficControlSystem.MoveLeft(x);
            BoardColoringSystem.Color(Console.CursorLeft % (x + 2), Console.CursorTop, seatList);
        }
    }
}
