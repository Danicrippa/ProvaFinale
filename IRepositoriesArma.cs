using System;

namespace ProvaFinale.Repositories
{
    public class IRepositoriesArma
    {
        public List<Arma> FetchArma(Eroe eroe)
        {
            List<Arma> armi = new List<Arma>();
            
            armi.Add(new Arma("Mazza", 5));

            return armi;
        }

    }
}
}
