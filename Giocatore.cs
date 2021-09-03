using System;
using System.Data.SqlClient;

namespace ProvaFinale.Entities
{
    public class Giocatore
    {
        public int ID { get; set; }
        public string Password { get; set; }
        public ICollection<Eroe> Eroe = new List<Eroe>();
        public override string ToString()
        {
            return $"ID: {ID} - Password: {Password}";
        }
    }
}
