using System;
using System.Data.SqlClient;

namespace ProvaFinale.Repositories
{
    public class IRepositoriesEroe
    {
        public List<Eroe> FetchEroi(Giocatore giocatore)
        {
            List<Eroe> eroe = new List<Eroe>();
            eroe.Add(new Eroe("PrimoEroe", new Arma("Ascia", 8), 1, CategoriaEroe.Guerriero, 20, 0));

            return eroe;
        }

        public void CreaEroe(Giocatore giocatore, Eroe eroe)
        {
            List<Eroe> eroe = new List<Eroe>();
            eroe.Add(eroe);
        }

        public void EliminaEroe(Giocatore giocatore, Eroe eroeEliminato)
        {
            List<Eroe> eroe = new List<Eroe>();
            eroe.Remove(eroeEliminato);
        }
    }
