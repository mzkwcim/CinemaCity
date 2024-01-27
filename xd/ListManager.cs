using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    internal class ListManager
    {
        internal List<string> seatList = new List<string>();
        public ListManager()
        {
            CreateAList();
        }
        public void ShowAList()
        {
            for (int i = 0; i < seatList.Count; i++)
            {
                Console.Write((i % 4 == 3) ? (i % 12 == 11) ? seatList[i] + "\n" : seatList[i] + " " : seatList[i]);
            }
        }
        public List<string> CreateAList()
        {
            for (int i = 0; i < Cinema.x.Length * Cinema.y.Length; i++)
            {
                seatList.Add("O");
            }
            return seatList;
        }
        public void ShowFreeSeatsCount()
        {
            ExitingSystem.ChangeConsoleColorToBlackAndClear();
            int adder = 0;
            for (int i = 0; i < seatList.Count; i++)
            {
                adder += (seatList[i] == "O") ? 1 : 0;
            }
            Console.WriteLine($"liczba wolnych miejsc {adder}\n\nkliknij dowolny przycisk, aby wrócić do menu głównego");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
