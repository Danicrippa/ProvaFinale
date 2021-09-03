using System;

namespace MostriVsEroi.View
{
    public static class RegistrazioneView
    {
        public static void Registrazione()
        {
            Giocatore giocatore = RichiestaDati.InserisciNomePassword();

            Console.WriteLine("Registrazione fatta.");

        }
    }
}
