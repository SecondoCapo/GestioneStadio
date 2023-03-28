using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campionato_Gruppo
{
    internal class Squadra
    {
        public Squadra() { }
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
        private String presidente;
        public String Presidente
        {
            get => presidente;
            set { presidente = value;}
        }
        private String allenatore;
        public String Allenatore
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
    }
}
