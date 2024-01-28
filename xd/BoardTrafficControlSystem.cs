using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class BoardTrafficControlSystem
    {
        public static void MoveUp() => Console.CursorTop = (Console.CursorTop - 1 < 0) ? (Cinema.y.Length - 1) : (Console.CursorTop - 1) % Cinema.y.Length;
        public static void MoveDown() => Console.CursorTop = (Console.CursorTop + 1 > Cinema.y.Length) ? 0 : (Console.CursorTop + 1) % Cinema.y.Length;
        public static void MoveLeft() => Console.CursorLeft = (Console.CursorLeft - 1 < 0) ? Cinema.x.Length + (Cinema.x.Length/5)-1 : ((Console.CursorLeft - 1) % 5 == 4) ? Console.CursorLeft - 2 : (Console.CursorLeft - 1) % (Cinema.x.Length + ((Cinema.x.Length / 4) - 1));
        public static void MoveRight() => Console.CursorLeft = (Console.CursorLeft + 1 > (Cinema.x.Length + Math.Floor(Cinema.x.Length / 5.0))) ? 0 : ((Console.CursorLeft + 1) % 5 == 4 && Console.CursorLeft + 1 != Cinema.x.Length+(Cinema.x.Length/5)) ? Console.CursorLeft + 2 : (Console.CursorLeft + 1) % (Cinema.x.Length + ((Cinema.x.Length / 4) - 1));
    }
}
