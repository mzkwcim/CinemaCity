using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class View
    {
        public static void Menu(string[] menu)
        {
            ExitTheCinema.ChangeConsoleColorToBlackAndClear();
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }
        }
        public static void DrawBoard(List<string> SeatList)
        {
            ExitTheCinema.ChangeConsoleColorToBlackAndClear();
            for (int i = 0; i < SeatList.Count; i++)
            {
                Console.Write((i % 4 == 3) ? (i % 12 == 11) ? SeatList[i] + "\n" : SeatList[i] + " " : SeatList[i]);
            }
        }
        public static void DrawBoardHelper(List<string> seatList)
        {
            View.DrawBoard(seatList);
            Console.WriteLine("\nAby wrócić do menu głównego wciśnij dowolny klawisz");
            Console.ReadKey();
        }
    }
}
