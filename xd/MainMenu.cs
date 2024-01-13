using CinemaCity;

Cinema.MainMenu();
class Cinema
{
    public static string[] y = new string[4];
    public static string[] x = new string[12];
    
    Cinema cinema = new Cinema();
    public static void MainMenu()
    {
        string[] menu = new string[] { "Menu", "Wybierz miejsce", "Sprawdź wolne miejsca", "Odwołaj rezerwacje", "Sprawdź liczbę wolnych miejsc", "Wyjdź z kina" };
        bool koniec = true;
        List<string> seatList = Initializer.SeatListCreater();
        while (koniec)
        {
            //dzisiaj nie dam rady już bardziej poprawić kodu, ale będę pracować nad tym o czym dzisiaj mi Pan mówił
            //int wybor = MenuHighlight.Highlight(menu)
            switch (MenuHighlight.Highlight(menu))
            {
                case 0: break;
                case 1: ChairsInCinema.ReserveASeatOrRevokeAReservation("X", seatList); break;
                case 2: View.DrawBoardHelper(seatList); break;
                case 3: ChairsInCinema.ReserveASeatOrRevokeAReservation("O", seatList); break;
                case 4: NumberOfFreeSeats.Counter(seatList); break;
                case 5: koniec = ExitTheCinema.ExitACinema(); break;
            }
        }
    }
}
class NumberOfFreeSeats
{
    public static void Counter(List<string> seatList)
    {
        ExitTheCinema.ChangeConsoleColorToBlackAndClear();
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
class Initializer
{
    public static List<string> SeatListCreater()
    {
        List<string> seatList = new List<string>();
        for (int i = 0; i < Cinema.x.Length * Cinema.y.Length; i++)
        {
            seatList.Add("O");
        }
        return seatList;
    }
}


