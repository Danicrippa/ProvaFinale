using System;
using System.Data.SqlClient;

namespace ProvaFinale.Entities
{
    public class Eroe
    {
        public string Nome { get; set; }
        public string IdCategoria { get; set; }
        public string IdArma { get; set; }
        public int PuntiDanno { get; set; }
        public int Livello { get; set; }
    }
}
