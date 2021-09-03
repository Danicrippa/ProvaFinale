using System;

namespace MostriVsEroi.View
{
    public static class Menu
    {
        internal static void MenuNonAutenticato(Giocatore giocatore)
        {
            bool vuoicontinuare = true;

            do
            {
                Console.WriteLine("Premi 1 per giocare");
                Console.WriteLine("Premi 2 per creare un nuovo eroe");
                Console.WriteLine("Premi 3 per elimanare eroe");
                Console.WriteLine("Premi 0 per finire");
                string scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        GiocaView.Gioca(giocatore);
                        break;

                    case "2":
                        CreaEroeView.CreaEroe(giocatore);
                        break;

                    case "3":
                        EliminaEroeView.EliminaEroe(giocatore);
                        break;

                    case "0":
                        Console.WriteLine("Ciao");
                        MainMenu();
                        vuoicontinuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata");
                        break;
                }
            } while (vuoicontinuare == true);
        }
    }
}
