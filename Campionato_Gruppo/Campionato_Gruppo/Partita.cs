using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campionato_Gruppo
{
    internal class Partita
    {
        public Partita() { }
        private int goalCasa;
        public int GoalCasa
        {
            get { return goalCasa; }
            set { goalCasa = value; }
        }
        private int goalOspiti;
        public int GoalOspiti
        {
            get => goalOspiti; set {  goalOspiti = value; }
        }
        private String data;
        public String Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        private Persona[] arbitri;
        public Persona[] Arbitri
        {
            get { return arbitri; }
            set { arbitri = value; }
        }
    }
}
