using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Campionato_Gruppo
{
    internal class Principale
    {
        static Persona objpersona= new Persona();
        static Campionato objCampionato=new Campionato();
        static Partita partita=new Partita();
        static String Squadra,Scelta;
        static Boolean esito =false;
        static int Casa, Ospiti;
        static String Data;
        static String Datag, Nomeg, Cognomeg, Datan, Nomen, Cognomen;

        static void Main(string[] args)
        {
            Console.WriteLine("Visualizzazzione squadre");
            while (!esito)
            {
                Console.Clear();
                Console.WriteLine("Inserisci un squadra");
                Squadra = Console.ReadLine();
                Squadra objSquadra = new Squadra(Squadra);
                objSquadra.Inserimento();
                objSquadra.Visualizza();
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Voui modificare qualche giocatore/allenatore/presidente?");
                Scelta= Console.ReadLine();
                if (Scelta.ToLower() == "si")
                {
                    Console.WriteLine("Inserisci rispettivamente la squadra, il nome, il cognome e la data di nascita del giocatore");
                    Squadra= Console.ReadLine();
                    Nomeg= Console.ReadLine();
                    Cognomeg= Console.ReadLine();
                    Datag= Console.ReadLine();
                    Console.WriteLine("Inserisci rispettivamente il nome, il cognome e la data di nascita del nuovo giocatore");
                    Nomen= Console.ReadLine();
                    Cognomen= Console.ReadLine();
                    Datan= Console.ReadLine();
                    objSquadra=new Squadra(Squadra);
                    objSquadra.Inserimento();
                    objSquadra.Modifica(Nomeg,Cognomeg,Datag,Nomen,Cognomen,Datan);
                    objSquadra.Visualizza();
                }
                Console.WriteLine("Vuoi continuare?");
                Scelta= Console.ReadLine();
                if (Scelta.ToUpper() == "NO")
                {
                    esito = true;
                }
            }
            Console.WriteLine("Partita");
            esito = false;
            objCampionato.Inserimento("");
            while (!esito)
            {
                Console.Clear();
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine((i+1) + "." + objCampionato.Squadre[i]);
                }
                Console.WriteLine("Inserisci la squadra di casa");
                Casa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci la squadra ospite");
                Ospiti = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci la data");
                Data = Console.ReadLine();
                partita=new Partita(Casa,Ospiti,Data,partita.Punti);
                partita.EstrazioneRisultato();
                Console.WriteLine("Vuoi continuare?");
                Scelta = Console.ReadLine();
                if (Scelta.ToUpper() == "NO")
                {
                    esito = true;
                }
            }
            Console.Clear();
            Console.WriteLine("Classifica:");
            for (int i = 0; i < partita.Punti.Length; i++)
            {
                Console.WriteLine(objCampionato.Squadre[i]+": " + partita.Punti[i]);
            }
            Console.WriteLine("Premere un tasto per uscire");
            Console.ReadKey();
        }
    }
}
