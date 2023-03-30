using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Campionato_Gruppo
{
    public class Partita
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
