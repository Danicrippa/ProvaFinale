using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;

namespace ProvaFinale
{
    public class Menu
    {
        public void MenuIniziale()
        {
            const string connectionString = "Server = (localdb)\\mssqllocaldb;Database=GiocoProvaFinale;Trusted_Connection=True";
            using (SqlConnection conn = new(connectionString))
            {
                conn.Open();
                {

                }
            }
        }

            public  void Accedere1(SqlConnection conn, int scelta, string ID, string Password)
            {

                Console.WriteLine("inserisci ID e Password");
                ID = Console.ReadLine();
                Password = Console.ReadLine();

                SqlCommand leggi = new();
                leggi.Connection = conn;
                leggi.CommandType = System.Data.CommandType.Text;
                leggi.CommandText = "SELECT * FROM Giocatore";


                SqlDataReader reader = leggi.ExecuteReader();
                Console.WriteLine();
                Console.WriteLine("ID", "Password");


                while (reader.Read())
                {
                    int i = reader.GetInt32(0);

                    Console.WriteLine(
                      (string)reader["ID"],
                        reader["Password"]
                    );
                }
            }

            public  void Registrare1(SqlConnection conn, int scelta, string ID, string Password)
            {

                Console.WriteLine("Creare ID");
                ID = Console.ReadLine();
                Console.WriteLine("Creare Password");
                Password = Console.ReadLine();

                SqlCommand leggi2 = new();
                leggi2.Connection = conn;
                leggi2.CommandType = System.Data.CommandType.Text;
                leggi2.CommandText = "SELECT * FROM Giocatore";

                SqlDataReader reader2 = leggi2.ExecuteReader();
                Console.WriteLine();
                Console.WriteLine("ID", "Password");


                while (reader2.Read())
                {
                    int i = reader2.GetInt32(0);

                    Console.WriteLine(
                      (string)reader2["ID"],
                        reader2["Password"]

                    );
                }
                if (scelta != 2)
                    Console.WriteLine("Errore di inserimento dati.");

                Console.Write("Premi un tasto ...");
                Console.ReadLine();
                conn.Close();

            }
        internal static void Accedere1()
        {

        }
        internal static void Registrare1()
            {

            }
        public class NotImplementedException : SystemException
        {

        }

    
       
    }

    
}





