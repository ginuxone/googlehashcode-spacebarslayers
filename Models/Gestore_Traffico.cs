using System;
using System.Collections.Generic;
using GoogleHashCode;

class Gestore_Traffico {
    public List <Intersezione> lista = new List <Intersezione>();
    public int durataSimulazione;
    public Gestore_Traffico (int durataSimulazione) {
        this.durataSimulazione= durataSimulazione;
    }

    public void addIntersezione (Intersezion i) {
        lista.Add(i);
    }

    
}