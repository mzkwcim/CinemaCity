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
            for (int i = 0; i < Cinema.menu.Count; i++)
            {
                Console.WriteLine(Cinema.menu[i]);
            }
        }
        public static void DrawBoard(ListManager listManager)
        {
            ExitingSystem.ChangeConsoleColorToBlackAndClear();
            for (int i = 0; i < listManager.seatList.Count; i++)
            {
                Console.Write((i % 4 == 3) ? (i % Cinema.x.Length == (Cinema.x.Length-1)) ? listManager.seatList[i] + "\n" : listManager.seatList[i] + " " : listManager.seatList[i]);
            }
        }
        public static void DrawBoardWithInstructions(ListManager listManager)
        {
            DrawBoard(listManager);
            Console.WriteLine("\nAby wrócić do menu głównego wciśnij dowolny klawisz");
            Console.ReadKey();
        }
    }
}
