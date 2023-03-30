using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Campionato_Gruppo
{
    public class Persona
    {
        public Persona() { }
        private String cognome;
        public String Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }
        private String nome;
        public String Nome
        {
            get
            {
                return nome;
            }
            set { nome = value; }
        }
        private String codiceFiscale;
        public String CodiceFiscale
        {
            get => codiceFiscale;
            set { codiceFiscale = value;}
        }
        private String dataNascita;
        public String DataNascita
        {
            get { return dataNascita; }
            set { dataNascita = value; }
        }
    }
}
