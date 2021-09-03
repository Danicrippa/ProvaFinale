using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threalind.Taks;

namespace ProvaFinale.Core.Entities

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
