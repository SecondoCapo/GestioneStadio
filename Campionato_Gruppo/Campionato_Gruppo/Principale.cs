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
        static void Main(string[] args)
        {
            Campionato objcampionato=new Campionato();
            objcampionato.Inserimanto();
            /*foreach (String elemento in objcampionato.Stringhe)
            {
                Console.WriteLine(elemento);
            }
            Console.ReadKey();*/
            Squadra objSquadra=new Squadra();
            objSquadra.Inserimento();
            objSquadra.Visualizza();
            Console.ReadLine();
        }
    }
}
