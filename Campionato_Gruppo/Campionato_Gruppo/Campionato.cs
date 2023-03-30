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
        static string line;
        public Campionato() { }
        private List<String[]> objgiocatori=new List<String[]>();
        public List<String[]> Objgiocatori
        {
            get { return objgiocatori; }
            set { objgiocatori = value;}
        }
        private List<String> stringe=new List<String>();
        public List<String> Stringhe
        {
            get { return stringe; }
            set { stringe = value; }
        }

        public void Inserimanto()
        {
            for (int i = 0; SR.EndOfStream; i++)
            {
                this.Stringhe.Add(SR.ReadLine());
            }
            /*while ((line = SR.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }*/
            //SR.ReadLine();
        }
    }
}
