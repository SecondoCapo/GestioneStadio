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
                if (i == objCampionato.Persone.Count - 1)
                {
                    Allenatore.Cognome = objCampionato.Persone[i].Cognome;
                    Allenatore.Nome= objCampionato.Persone[i].Nome;
                    Allenatore.DataNascita = objCampionato.Persone[i].DataNascita;
                    Allenatore.CodiceFiscale = objCampionato.Persone[i].CodiceFiscale;
                }
                else if ( i == objCampionato.Persone.Count - 2)
                {
                    Presidente.Cognome = objCampionato.Persone[i].Cognome;
                    Presidente.Nome = objCampionato.Persone[i].Nome;
                    Presidente.DataNascita = objCampionato.Persone[i].DataNascita;
                    Presidente.CodiceFiscale = objCampionato.Persone[i].CodiceFiscale;
                }
                
                else
                {
                    Giocatori.Add(new Persona()
                    {
                        Nome = objCampionato.Persone[i].Nome,
                        Cognome = objCampionato.Persone[i].Cognome,
                        DataNascita = objCampionato.Persone[i].DataNascita,
                        CodiceFiscale = objCampionato.Persone[i].CodiceFiscale,
                    });
                }
                
            }
        }
        public void Visualizza()
        {
            for (int i = 0; i < this.Giocatori.Count; i++)
            {
                Console.WriteLine(Giocatori[i].Cognome + " " + Giocatori[i].Nome + " " + Giocatori[i].DataNascita + " " + Giocatori[i].CodiceFiscale);
            }
            Console.WriteLine("Allenatore: " + Allenatore.Cognome + " " + Allenatore.Nome+" "+Allenatore.DataNascita+" "+Allenatore.CodiceFiscale);
            Console.WriteLine("Presidente: " + Presidente.Cognome + " " + Presidente.Nome + " " + Presidente.DataNascita + " " + Presidente.CodiceFiscale);
        }
        public void Modifica(String _nome, String _cognome, String _data,String _nomen,String _cognomen, String _datan)
        {
            for (int i = 0; i < this.Giocatori.Count; i++)
            {
                if ((this.Giocatori[i].Nome == _nome) && (this.Giocatori[i].Cognome == _cognome) && (this.Giocatori[i].DataNascita==_data))
                {
                    this.Giocatori[i].Nome = _nomen;
                    this.Giocatori[i].Cognome = _cognomen;
                    this.Giocatori[i].DataNascita = _datan;
                }
            }
        }
    }
}
