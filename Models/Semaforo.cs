using System.Collections.Generic;
using GoogleHashCode;

class Semaforo
{
    public bool stato; // (false= red , true= red)
    public int TVerde;
    public List<Macchina> coda= new List<Macchina>();

    public Semaforo()
    {
        stato = false;
        TVerde = 0;
    }

}