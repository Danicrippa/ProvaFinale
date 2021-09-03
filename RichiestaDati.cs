using System;

namespace MostriVsEroi.View
{
    public static class RichiestaDati
    {
        public static Giocatore InserisciNomePassword()
        {
            Console.WriteLine("Inserisci nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci password");
            string password = Console.ReadLine();

            return GiocatoreSchermataService.GetGiocatore(nome, password);

        }
    }
}

