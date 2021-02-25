using System;
using System.Collections.Generic;
using GoogleHashCode;

class Gestore_Traffico {
    public List <Intersezione> lista_Intersezioni = new List <Intersezione>();

    public List <Macchina> lista_MacchineTragitto = new List<Macchina> ();
    public int durataSimulazione;
    public Gestore_Traffico (int durataSimulazione) {
        this.durataSimulazione= durataSimulazione;
    }

    public void addIntersezione (Intersezion i) {
        lista.Add(i);
    }

   
}