using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Campionato_Gruppo
{
    public class Campionato
    {
        static StreamReader SR = new StreamReader("Squadra.txt");
        public Campionato() { }
        private List<String[]> objgiocatori=new List<String[]>();
        public List<String[]> Objgiocatori
        {
            get { return objgiocatori; }
            set { objgiocatori = value;}
        }
        private List<Persona> persone=new List<Persona>();
        public List<Persona> Persone
        {
            get { return persone; }
            set { persone = value; }
        }
        /*private List<String> stringe=new List<String>();
        public List<String> Stringhe
        {
            get { return stringe; }
            set { stringe = value; }
        }*/

        public void Inserimento(String _squadra)
        {
            String line;
            SR = new StreamReader("Squadra.txt");
            List<String> squadre = new List<String>();
            String[] stringhe = null;
            while ((line = SR.ReadLine()) != null)
            {
                stringhe = line.Split(',');
                if (stringhe[3] == _squadra)
                {
                    this.Persone.Add(new Persona()
                    {
                        Nome = stringhe[1],
                        Cognome = stringhe[0],
                        DataNascita = stringhe[2],
                        CodiceFiscale = "NO DATA",
                    });
                }
                squadre.Add(stringhe[3]);
            }
            
            squadre=squadre.Distinct().ToList();
            /*foreach (String elemento in squadre)
            {
                Console.WriteLine(elemento);
            }*/
        }
        public void StampaGiocatori()
        {
            foreach (Persona elemento in Persone)
            {
                Console.WriteLine(elemento.Nome + " " + elemento.Cognome + " " + elemento.DataNascita + " " + elemento.CodiceFiscale);
                
            }
        }
    }
}
