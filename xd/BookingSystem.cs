using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity
{
    class BookingSystem
    {
        public static void ReserveASeat(string sign)
        {
            bool koniec = true;
            do
            {
                try
                {
                    int[] tab = ChairsHighlightingSystem.HighlightACertainPlaceOnBoard();
                    ExitingSystem.ChangeConsoleColorToBlackAndClear();
                    if (ListMeneger.seatList[(tab[1] * Cinema.x.Length) + tab[0]] == sign)
                    {
                        Console.WriteLine("Nie możesz wybrać zajętego miejsca\nWciśnij dowolny klawisz aby kontynuować");
                        Console.ReadKey();
                    }
                    else
                    {
                        ListMeneger.seatList[(tab[1] * Cinema.x.Length) + tab[0]] = sign;
                        Console.SetCursorPosition(0, 0);
                        DisplaySystem.DrawBoard();
                        Console.WriteLine($"\nwybrałeś miejsce w rzędzie {tab[1] + 1} kolumna {tab[0] + 1}");
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
        public static void RevokeAReservation(string sign)
        {
            bool koniec = true;
            do
            {
                try
                {
                    int[] tab = ChairsHighlightingSystem.HighlightACertainPlaceOnBoard();
                    ExitingSystem.ChangeConsoleColorToBlackAndClear();
                    if (ListMeneger.seatList[(tab[1] * Cinema.x.Length) + tab[0]] == sign)
                    {
                        Console.WriteLine("Nie możesz odwołać rezerwacji wolnego miejsca\nWciśnij dowolny klawisz aby kontynuować");
                        Console.ReadKey();
                    }
                    else
                    {
                        ListMeneger.seatList[(tab[1] * Cinema.x.Length) + tab[0]] = sign;
                        Console.SetCursorPosition(0, 0);
                        DisplaySystem.DrawBoard();
                        Console.WriteLine($"\nOdwołałeś rezerwacje miejsca  w rzędzie {tab[1] + 1} kolumnie {tab[0] + 1}");
                        Console.WriteLine("Aby wrócić do menu głównego wciśnij dowolny klawisz");
                        Console.ReadKey();
                        koniec = false;
                    }
                }
                catch
                {
                    koniec = false;
                }
            }while(koniec);
        }
    }
}
