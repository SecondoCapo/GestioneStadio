using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Campionato_Gruppo
{
    internal class Squadra: Persona
    {
        Campionato objCampionato = new Campionato();
        public Squadra() { }
        public Squadra(String _nomesquadra)
        {
            this.NomeSquadra = _nomesquadra;
        }
        
        private String nomeSquadra;
        public String NomeSquadra
        {
            get { return nomeSquadra; }
            set { nomeSquadra = value;}
        }
        private String nomeStadio;
        public String NomeStadio
        {
            get
            {
                return nomeStadio;
            }
            set { nomeStadio = value;}
        }
        private Persona presidente=new Persona();
        public Persona Presidente
        {
            get => presidente;
            set { presidente = value;}
        }
        private Persona allenatore = new Persona();
        public Persona Allenatore
        {
            get { return allenatore;}
            set { allenatore = value;}
        }
        private List<Persona> giocatori = new List<Persona>();
        public List<Persona> Giocatori
        {
            get { return giocatori; }
            set { giocatori = value;}
        }
        
        public void Inserimento()
        {
            objCampionato.Inserimento(this.NomeSquadra);
            for (int i = 0; i < objCampionato.Persone.Count; i++)
            {
                Giocatori.Add(new Persona()
                {
                    Nome= objCampionato.Persone[i].Nome,
                    Cognome= objCampionato.Persone[i].Cognome,
                    DataNascita= objCampionato.Persone[i].DataNascita,
                    CodiceFiscale= objCampionato.Persone[i].CodiceFiscale,
                });
            }
        }
        public void Visualizza()
        {
            for (int i = 0; i < Giocatori.Count; i++)
            {
                //Console.WriteLine(Giocatori[i].Nome);
                Console.WriteLine(Giocatori[i].Cognome + " " + Giocatori[i].Nome + " " + Giocatori[i].DataNascita + " " + Giocatori[i].CodiceFiscale);
            }
        }
    }
}
