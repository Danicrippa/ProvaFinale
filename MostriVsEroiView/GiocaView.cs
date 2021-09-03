using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MostriVsEroiView.MostriVsEroeServizi
{
    public class GiocaView
    {
        const string connectionString = "Server = (localdb)\\mssqllocaldb;Database=GiocoProvaFinale;Trusted_Connection=True";
        internal static void Gioca(Giocatore giocatore)
        {

            //Eroe eroe = EroeServizi.ScegliEroe(giocatore);
            //Mostri mostri = MostriServizi.ScegliMostro(giocatore);
            //if (mostri.Livello <= eroe.Livello)
            //{
            //    Console.WriteLine(MostriServizi.ScegliMostro(giocatore));
            //}
            //Partita(eroe, mostri, giocatore);

        }

        //public static Giocatore ScegliEroe(Giocatore giocatore)
        //{
        //    //Console.WriteLine("Eroe scelto:");
            //List<Eroe> eroi = EroeServizi.GetEroi(giocatore);
            //if (eroi.Count > 0)
            //{
            //    int count = 1;
            //    bool conversioneRiuscita = false;
            //    int eroescelto = 0;
            //    do
            //    {
            //        System.Collections.IList list1 = eroi;
            //        for (int i = 0; i < list1.Count; i++)
            //        {
            //            Giocatore eroe = (Giocatore)list1[i];
            //            Console.WriteLine($"Premi {count} per  eroe {eroe.Nome}, tipo {Categoria.Guerriero} " +
            //                    $"  arma {eroe.Arma} con {eroe.PuntiDanno} punti danno,  livello {eroe.Livello} e vita {eroe.PuntiVita}");
            //            count++;
            //        }
            //        conversioneRiuscita = int.TryParse(Console.ReadLine(), out eroescelto);

            //    } while (!conversioneRiuscita || eroescelto < 1 || eroescelto > eroi.Count);
            //    //ritorno l'eroe
            //    return eroi[--eroescelto];
            //}
            //else
            //{
            //    Console.WriteLine("Nessun eroe in lista");
            //    return null;
        }
    }


    //private static void Partita(Giocatore eroe, Mostri mostri, Giocatore giocatore)
    //{

        //do
        //{
        //    Console.WriteLine("Gioca partita!");
        //    Console.WriteLine("Premi 1 per attaccare");
        //    Console.WriteLine("Premi 2 per la fuga");
        //    Console.WriteLine();
        //    string scelta = Console.ReadLine();

        //switch (scelta)
        //{
        //    case "1":

        //        do
        //        {
        //            EroeServizi.AttaccoEroe(eroe, mostri);
        //            MostroiServizi.AttaccoMostro(eroe, mostri);
        //        } while (eroe.PuntiVita > 0 && mostri.PuntiVita > 0);
        //        if (eroe.PuntiVita == 0)
        //        {
        //            Console.WriteLine("Hai perso!");

        //        }
        //        if (mostri.PuntiVita == 0)
        //        {
        //            Console.WriteLine("Hai vinto");
        //        }
        //        break;

        //    case "2":

        //        break;
        //}
        //} while (true);
//    }
//}


