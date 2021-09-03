using System;
using System.Data.SqlClient;

namespace ProvaFinale.Repositories
{
    public class IRepositoriesMostri
    {
            public List<Mostri> FetchMostri(Giocatore giocatore)
            {
                List<Mostri> mostri = new List<Mostri>();
                mostri.Add(new Mostri(CategoriaMostri.Orco, new Arma("Clava", 5), 2, 40));

                return mostri;
            }
        }

