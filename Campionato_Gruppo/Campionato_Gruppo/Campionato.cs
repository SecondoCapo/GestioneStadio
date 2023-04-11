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
        //static StreamWriter SW;
        public Campionato() { }
        
        private List<String[]> objgiocatori=new List<String[]>();
        public List<String[]> Objgiocatori
        {
            get { return objgiocatori; }
            set { objgiocatori = value;}
        }
        private int[] punti = new int[20];
        public int[] Punti
        {
            get { return punti; }
            set { punti = value; }
        }
        private List<Persona> persone=new List<Persona>();
        public List<Persona> Persone
        {
            get { return persone; }
            set { persone = value; }
        }
        private List<String> squadre = new List<String>();
        public List<String> Squadre
        {
            get { return squadre; }
            set { squadre = value; }
        }
        public void Inserimento(String _squadra)
        {
            String line;
            SR = new StreamReader("Squadra.txt");
            Squadre.Clear();
            
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
                Squadre.Add(stringhe[3]);
            }
            
            Squadre=Squadre.Distinct().ToList();
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
        public void IniziaArray()
        {
            for (int i = 0; i < this.Punti.Length; i++)
            {
                this.Punti[i] = 0;
            }
        }
        /*public void ModificaTXT(String _nome, String _cognome, String _data,String _nomen, String _cognomen, String _datan)
        {
            SR = new StreamReader("Squadra.txt");
            string line = "";
            
            using (StreamWriter SW = new StreamWriter("Squadra.txt"))
            {
                String[] stringhe = null;
                while ((line = SR.ReadLine()) != null)
                {
                    stringhe = line.Split(',');
                    if ((_cognome == stringhe[0]) && (_nome == stringhe[1]))
                    {
                        SW.WriteLine(_cognomen + "," + _nomen + "," + _datan);
                    }
                }
                SR.Close();
            }
        }*/
    }
}
