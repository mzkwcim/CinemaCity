using CinemaCity;
using System.Runtime.CompilerServices;


Cinema.MainMenu();
class Cinema
{
    internal static string[] y = new string[4];
    internal static string[] x = new string[12];
    internal static string[] menu = new string[] { "Menu", "Wybierz miejsce", "Sprawdź wolne miejsca", "Odwołaj rezerwacje", "Sprawdź liczbę wolnych miejsc", "Wyjdź z kina" };
    public static void MainMenu()
    {
        bool koniec = true;
        ListMeneger.CreateAList();
        while (koniec)
        {
            //dzisiaj nie dam rady już bardziej poprawić kodu, ale będę pracować nad tym o czym dzisiaj mi Pan mówił
            int choice = MenuHighlightingSystem.HighlightACertainOption();
            switch (choice)
            {
                case 0: break;
                case 1: BookingSystem.ReserveASeat("X"); break;
                case 2: DisplaySystem.DrawBoardWithInstructions(); break;
                case 3: BookingSystem.RevokeAReservation("O"); break;
                case 4: ListMeneger.ShowFreeSeatsCount(); break;
                case 5: koniec = ExitingSystem.ExitACinema(); break;
            }
        }
    }
}
class ListMeneger
{
    public static List<string> seatList = new List<string>();
    public static void ShowAList()
    {
        for (int i = 0; i < seatList.Count; i++)
        {
            Console.Write((i % 4 == 3) ? (i % 12 == 11) ? seatList[i] + "\n" : seatList[i] + " " : seatList[i]);
        }
    }
    public static List<string> CreateAList()
    {
        for (int i = 0; i < Cinema.x.Length * Cinema.y.Length; i++)
        {
            seatList.Add("O");
        }
        return seatList;
    }
    public static void ShowFreeSeatsCount()
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


