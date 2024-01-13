using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class ColorABoard
    {
        public static void Color(int x, int y, List<string> seatList)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(seatList[(y * seatList.Count / Cinema.y.Length) + ((x < 4) ? x : (x > 4 && x < 9) ? x - 1 : x - 2)]);
            Console.SetCursorPosition(x, y);
        }
        public static void UnColor(int x, int y, List<string> seatList)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(seatList[(y * seatList.Count / Cinema.y.Length) + ((x < 4) ? x : (x > 4 && x < 9) ? x - 1 : x - 2)]);
            Console.SetCursorPosition(x, y);
        }
    }
}
