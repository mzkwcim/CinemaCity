using CinemaCity;
using System.Runtime.CompilerServices;


Cinema.MainMenu();
class Cinema
{
    internal static string[] y = new string[4];
    internal static string[] x = new string[12];
    internal static List<string> menu = new () { "Menu", "Wybierz miejsce", "Sprawdź wolne miejsca", "Odwołaj rezerwacje", "Sprawdź liczbę wolnych miejsc", "Wyjdź z kina" };
    public static void MainMenu()
    {
        bool koniec = true;
        ListManager listManager = new ListManager();
        while (koniec)
        {
            //dzisiaj nie dam rady już bardziej poprawić kodu, ale będę pracować nad tym o czym dzisiaj mi Pan mówił
            int choice = MenuHighlightingSystem.HighlightACertainOption();
            switch (choice)
            {
                case 0: break;
                case 1: BookingSystem.ReserveASeat("X", listManager); break;
                case 2: DisplaySystem.DrawBoardWithInstructions(listManager); break;
                case 3: BookingSystem.RevokeAReservation("O", listManager); break;
                case 4: listManager.ShowFreeSeatsCount(); break;
                case 5: koniec = ExitingSystem.ExitACinema(); break;
            }
        }
    }
}



