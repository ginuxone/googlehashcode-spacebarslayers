using System.Collections.Generic;
using GoogleHashCode;

class Semaforo
{
    public bool stato; // (false= red , true= red)
    public int TVerde;
    public List<Macchina> coda = new List<Macchina> ();
    int priorita;

    public Semaforo()
    {
        stato = false;
        TVerde = 0;
        priorità = 0;
    }

    private calcolaPriorita () {
        int ris = 0;

        for (int i= 0; i< coda.Count(); i++) {
            ris += coda.Items(i); //(coda.Items(i).priorita > ris)
        }
        return ris;
    }

    public void addinCoda (Macchina m) {
        coda.Add(m);
    }

    public void pop () {
        coda.RemoveAt(0);
    }

}