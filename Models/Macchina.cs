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

        public Macchina(List<Strada> p)
        {
            id = this.Crea_id();
            percorso = p;
            stimato = 0;
            posCoda = targa;
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
                    stimato = percorso.First().TPercorrenza;

                else
                    stimato = -1; // percorso concluso
            }
        }
        public void calcolaTPercorso(){
            int tTotale=0;
            bool first=true;
            foreach (Strada item in this.percorso)
            {
                if(first){
                    first=false;
                }else{
                    tTotale=item.TPercorrenza+1;
                }
            }
        }
    }
}
