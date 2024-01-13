using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class ChairsInCinema
    {
        public static void ReserveASeatOrRevokeAReservation(string sign, List<string> seatList)
        {
            bool koniec = true;
            do
            {
                try
                {
                    int[] tab = ArrowManagementSystemOnBoard.Highlight(seatList);
                    ExitingSystem.ChangeConsoleColorToBlackAndClear();
                    if (seatList[(tab[1] * Cinema.x.Length) + tab[0]] == sign)
                    {
                        Console.WriteLine((sign == "X") ? "Nie możesz wybrać zajętego miejsca\nWciśnij dowolny klawisz aby kontynuować" : "Nie możesz odwołać rezerwacji wolnego miejsca");
                        Console.ReadKey();
                    }
                    else
                    {
                        seatList[(tab[1] * Cinema.x.Length) + tab[0]] = sign;
                        Console.SetCursorPosition(0, 0);
                        DisplaySystem.DrawBoard(seatList);
                        Console.WriteLine((sign == "X") ? $"\nwybrałeś miejsce w rzędzie {tab[1] + 1} kolumna {tab[0] + 1}" : $"Odwołałeś rezerwacje miejsca  w rzędzie {tab[1] + 1} kolumnie {tab[0] + 1}");
                        Console.WriteLine("Aby wrócić do menu głównego wciśnij dowolny klawisz");
                        Console.ReadKey();
                        koniec = false;
                    }
                }
                catch
                {
                    koniec = false;
                }
            } while (koniec);
        }
    }
}
