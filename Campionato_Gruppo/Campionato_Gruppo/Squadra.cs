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
        public Squadra() { }
        public Squadra(String _presidente, String _allenatore)
        {
            
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
        private Persona[] giocatori = new Persona[30];
        public Persona[] Giocatori
        {
            get { return giocatori; }
            set { giocatori = value;}
        }
        
        public void Inserimento()
        {

            
        }
        public void Visualizza()
        {
            
        }
    }
}
