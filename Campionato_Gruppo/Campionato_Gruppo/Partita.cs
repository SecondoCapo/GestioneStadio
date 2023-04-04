using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Campionato_Gruppo
{
    public class Partita:Campionato
    {
        static Random urna=new Random();
        static Campionato objCampionato= new Campionato();
        static int nC, nO;
        public Partita() { }
        public Partita(int _casa, int _ospiti, String _data, int[] punti)
        {
            _casa--;
            _ospiti--;
            for(int i=0; i<punti.Length; i++)
            {
                this.Punti[i] = punti[i];
            }
            nC = _casa;
            nO = _ospiti;
            objCampionato.Inserimento("");
            this.Casa = objCampionato.Squadre[_casa];
            this.Ospiti = objCampionato.Squadre[_ospiti];
            this.Data = _data;
        }
        private String casa;
        public String Casa
        {
            get { return casa; } set {  casa = value; }
        }
        private String ospiti;
        public String Ospiti
        {
            get => ospiti; set {  ospiti = value; }
        }

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
        public void EstrazioneRisultato()
        {
            this.GoalCasa = urna.Next(1, 6);
            this.GoalOspiti=urna.Next(1,6);
            if (this.GoalCasa > this.GoalOspiti)
            {
                Console.WriteLine(this.Casa+":"+this.GoalCasa+" "+this.Ospiti+":"+this.GoalOspiti);
                Console.WriteLine("Vince: " + this.Casa);
                this.Punti[nC] = this.Punti[nC]+3;
            }
            else if (this.GoalOspiti > this.GoalCasa)
            {
                Console.WriteLine(this.Casa + ":" + this.GoalCasa + " " + this.Ospiti + ":" + this.GoalOspiti);
                Console.WriteLine("Vince: " + this.Ospiti);
                this.Punti[nO] = this.Punti[nO]+ 3;
            }
            else
            {
                Console.WriteLine(this.Casa + ":" + this.GoalCasa + " " + this.Ospiti + ":" + this.GoalOspiti);
                Console.WriteLine("Pareggio");
                this.Punti[nC] = this.Punti[nC]+1;
                this.Punti[nO] = this.Punti[nO]+ 1;
            }
        }
    }
}
