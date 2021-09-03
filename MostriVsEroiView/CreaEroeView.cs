using IRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using MostriVsEroi.Servizi.MostriVsEroi.Servizi;

namespace MostriVsEroiView
{
    public static class CreaEroeView
    {
        const string connectionString = "Server = (localdb)\\mssqllocaldb;Database=GiocoProvaFinale;Trusted_Connection=True";
           
        //public static Eroe CreaEroe(Giocatore giocatore)
        //{
        //    Eroe eroe = new Eroe();
        //    Console.WriteLine("Crea un eroe");
        //    Console.WriteLine("Inserisci nome eroe");
        //    string nome = Console.ReadLine();
        //    eroe.Nome = nome;
        //    Console.WriteLine("Scegli la categoria : premi 0 per Guerriero - premi 1 per Mago ");
        //    int categoria = int.Parse(Console.ReadLine());
        //    eroe.Categoria = (Categoria)categoria;
        //    Console.WriteLine($"Categoria scelta: {categoria}");


        //    Console.WriteLine("Scegli l'arma");
        //    Console.WriteLine("Scegli i punti danno");

            
        //}
    }
}
