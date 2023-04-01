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
        static String Squadra,Scelta;
        static Boolean esito =false;

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
                Console.WriteLine("Vuoi continuare?");
                Scelta= Console.ReadLine();
                if (Scelta.ToUpper() == "NO")
                {
                    esito = true;
                }
            }
        }
    }
}
