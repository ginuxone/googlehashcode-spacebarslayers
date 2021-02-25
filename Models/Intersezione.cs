class Intersezione {
    String id;
    Stada [] strade;
    private static int temp = 0;

    public Intersezione () {
        id = crea_id ();
    }

    private String crea_id () {
    return String.concat("Intersezione", String.toString(++temp));
    }
}