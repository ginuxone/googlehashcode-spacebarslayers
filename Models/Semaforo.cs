using System.Collections.Generic;
using GoogleHashCode;
using System.Linq;

class Semaforo
{
    public bool stato; // (false= red , true= red)
    public int TVerde;
    public List<Macchina> coda = new List<Macchina> ();
    public int priorita;

    public Semaforo()
    {
        stato = false;
        TVerde = 0;
        priorita = 0;
    }

    public int CalcolaPriorita () {
        int ris = 0;
        foreach (Macchina item in coda)
        {
            ris+=item.priorita;
        }
        return ris;
    }

    public void addinCoda (Macchina m) {
        coda.Add(m);
        priorita=CalcolaPriorita();
    }

    public void pop () {
        coda.RemoveAt(0);
    }

}