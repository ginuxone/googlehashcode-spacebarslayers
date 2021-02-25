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
}