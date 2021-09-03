using System;

namespace MostriVsEroi.View
{
    public static class EliminaEroeView
    {
        public static void EliminaEroe(Utente utente)
        {
            Console.WriteLine("Procedi con l'eliminazione dell'eroe");
            Console.WriteLine("Scegli eroe che vuoi eliminare");
            List<Eroe> eroi = EroeService.GetEroi(utente);
            foreach (Eroe eroe in eroi)
            {
                Console.WriteLine(eroe);
            }
            string nomeEroe = Console.ReadLine();

            Eroe eroeEliminato = new Eroe(nomeEroe);
            eroi.Remove(eroeEliminato);