using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class DisplaySystem
    {
        public static void Menu()
        {
            ExitingSystem.ChangeConsoleColorToBlackAndClear();
            for (int i = 0; i < Cinema.menu.Length; i++)
            {
                Console.WriteLine(Cinema.menu[i]);
            }
        }
        public static void DrawBoard()
        {
            ExitingSystem.ChangeConsoleColorToBlackAndClear();
            for (int i = 0; i < ListMeneger.seatList.Count; i++)
            {
                Console.Write((i % 4 == 3) ? (i % 12 == 11) ? ListMeneger.seatList[i] + "\n" : ListMeneger.seatList[i] + " " : ListMeneger.seatList[i]);
            }
        }
        public static void DrawBoardWithInstructions()
        {
            DrawBoard();
            Console.WriteLine("\nAby wrócić do menu głównego wciśnij dowolny klawisz");
            Console.ReadKey();
        }
    }
}
