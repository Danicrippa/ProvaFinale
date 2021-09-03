using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.View
{
	static class AccediView
	{
		public static void Accedi()
        {
			Giocatore giocatore = RichiestaDati.InserisciNomePassword();
			giocatore = GiocatoreService.VerifyAuthentication(giocatore);
			if(giocatore.IsAutenticated && giocatore.IsAdmin)
            {
				//menuAdmin
            }
			else if(giocatore.IsAuthenticated && !giocatore.IsAdmin)
            {
				Menu.MenuNonAutenticato(giocatore);
            }
            else
            {
                Console.WriteLine("Fare prima la registrazione");
                RegistrazioneView.Registrazione();
            }
        }


	}
}
