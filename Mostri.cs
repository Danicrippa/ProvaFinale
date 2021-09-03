using System;
using System.Data.SqlClient;

namespace GiocoProvaFinale.Core.Entities
{
    public class Mostri
    {
        public int PuntiDanno { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Livello { get; set; }
    }
}