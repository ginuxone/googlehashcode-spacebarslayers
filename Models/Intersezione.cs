using System;
using System.Collections.Generic;
using GoogleHashCode;
class Intersezione {
    String id;
    List<Strada> strade;
    private static int temp = 0;

    public Intersezione () {
        id = crea_id ();
    }

    private String crea_id () {
        String res=String.Concat("Intersezione", temp.ToString()));
        temp++;
        return res;
    }
}