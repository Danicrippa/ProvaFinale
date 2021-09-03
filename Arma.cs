using System;
using System.Data.SqlClient;

namespace ProvaFinale.Entities
{
	public class Arma
	{
		public int ID { get; set; }
		public string Nome { get; set; }
		public int Danno { get; set; }
		public string Categoria { get; set; }
	}
}
