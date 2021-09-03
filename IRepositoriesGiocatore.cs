using System;
using System.Data.SqlClient;

namespace ProvaFinale.Repositories
{
    
    public interface IRepositoriesGiocatore
    {
        public IList<Giocatore> GetAll();
        public User GetByPassword(string password);
        public void Add(Giocatore giocatore);
    }
}
}
