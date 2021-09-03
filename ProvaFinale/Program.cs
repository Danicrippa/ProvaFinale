using System;
using System.IO;
using System.Data.SqlClient;

namespace ProvaFinale
{
    public class Program
    {

        public static void Main(string[] args)
        {
            
                const string connectionString = "Server = (localdb)\\mssqllocaldb;Database=GiocoProvaFinale;Trusted_Connection=True";
                using (SqlConnection conn = new(connectionString))
                {
                    conn.Open();
                    {

            
                Console.WriteLine("Gioco Eroe X Mostri");
                Console.WriteLine("____________________");
                Console.WriteLine("premi 1  per Accedere ao Gioco");
                Console.WriteLine("premi 2 per Registrati nel Gioco");
                Console.WriteLine("premi 0 per Uscire del Gioco");

                bool isInt = true;
                int scelta = 0;

                do
                {
                    isInt = int.TryParse(Console.ReadLine(), out scelta);
                } while (!isInt);

                if (scelta == 1)
                {
                    Console.WriteLine("Hai scelto accedere al gioco");
                    Menu.Accedere1();
                }
                else if (scelta == 2)
                {
                    Console.WriteLine("Deve prima registrare");
                    Menu.Registrare1();
                }
                else if (scelta == 0)
                {
                    Console.WriteLine("Finito.");
                }

                else if (scelta != 2)
                {
                    Console.WriteLine("Scelta sbagliata, devi scegliere un numero tra 0 e 2:");

                    Console.Write("Premi un tasto ...");
                    Console.ReadLine();
                }
                    conn.Close();

                }

            }
        }
    }
}






