using System;
using GoogleHashCode;

class Macchina {
    int stimato; // indica i secondi per arrivare a fine strade
    public String id;
    List<Strada> percorso;
    public static int targa = 0;

    public Macchina (List <Strada> p) {
        id=this.Crea_id();
        percorso = p;
        stimato= 0;
    }

    public String Crea_id() {
        String res=String.Concat("Macchina", targa.ToString());
        targa++;
        return res;
    }

    public void procede () {   // strutturare il codice in modo che non si possa eseguire "procedere" e "passaSemaforo" assieme
        if (stimato== 0) 
            Console.WriteLine ("La macchina è gia al semaforo")
        
        else {
            --stimato
        }
    }

    public void passaSemaforo () {
        if (stimato!= 0)
            Console.WriteLine ("Macchina non ancora arrivata al semaforo");
        
        else {
            percorso.RemoveAt(0);
            if (percorso.Count > 0) 
                stimato = percorso.Items(0);
            
            else 
                stimato =  -1; // percorso concluso
        }
    }
}