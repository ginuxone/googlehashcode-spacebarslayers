class Semaforo
{
    public bool stato; // (false= red , true= red)
    public int TVerde;
    public List<Macchina> coda;

    public Semaforo()
    {
        stato = false;
        TVerde = 0;
    }

}