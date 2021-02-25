using System;
using System.Collections.Generic;
using System.Linq;
using GoogleHashCode;

namespace GoogleHashCode
{
    class Macchina
    {
        int stimato; // indica i secondi per arrivare a fine strade
        public String id;
        List<Strada> percorso = new List<Strada>();
        public static int targa = 0;
        public int posCoda;
        public int priorita;

        public Macchina(List<Strada> p)
        {
            id = this.Crea_id();
            percorso = p;
            stimato = 0;
        }

        public String Crea_id()
        {
            String res = String.Concat("Macchina", targa.ToString());
            targa++;
            return res;
        }

        public void procede()
        {   // strutturare il codice in modo che non si possa eseguire "procedere" e "passaSemaforo" assieme
            if (stimato == 0)
                Console.WriteLine("La macchina è gia al semaforo");
            else
            {
                --stimato;
            }
        }

        public void passaSemaforo()
        {
            if (stimato != 0)
                Console.WriteLine("Macchina non ancora arrivata al semaforo");

            else
            {
                percorso.RemoveAt(0);
                if (percorso.Count > 0)
                    stimato = percorso.First().TPercorrenza +1;

                else
                    stimato = -1; // percorso concluso
            }
        }
        public int calcolaTPercorso(){
            int tTotale=1;
            bool first=true;
            foreach (Strada item in this.percorso)
            {
                if(first){
                    first=false;
                }else{
                    tTotale=item.TPercorrenza+1;
                }
            }
            return tTotale;
        }
        public void SetPriorita(int durataSimulazione, int bonus){
            if(calcolaTPercorso()>durataSimulazione){
                this.priorita=0;
            }else {
                this.priorita=(durataSimulazione-calcolaTPercorso())+bonus;
                foreach (Strada item in percorso)
                {
                    this.priorita-=item.semaforo.coda.Count;
                }
            }
        }
        public void AbbassaPriorita(){
            this.priorita=(this.priorita>1?-1:0);
        }
        public void AlzaPriorita(){
            this.priorita++;
        }
    }
}
