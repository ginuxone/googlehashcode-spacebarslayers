using System;
using System.Collections.Generic;
using GoogleHashCode;

class Intersezione {
    String id;
    List<Strada> l_strade;
    private static int temp = 0;

    public Intersezione (List <Strada> l) {
        id = crea_id ();
        l_strade = l;
    }

    private String crea_id () {
        String res=String.Concat("Intersezione", temp.ToString());
        temp++;
        return res;
    }
}