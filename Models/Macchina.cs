using System;
using GoogleHashCode;

class Macchina {
    int stato;
    public String id;
    Strada[] percorso;
    public static int targa = 0;

    public Macchina (Strada [] p) {
        id=this.Crea_id();
        percorso = p;
        stato= 1;
    }

    public String Crea_id() {
        String res=String.Concat("Macchina", targa.ToString());
        targa++;
        return res;
    }
}