class Macchina
{
    int stato;
    String id;
    Street[] percorso;
    private static int targa = 0;

    public Macchina(Street[] p)
    {
        id = crea_id();
        percorso = p;
        stato = 1;

    }

    private crea_id()
    {
        return String.concat("car", String.toString(++targa));
    }

}