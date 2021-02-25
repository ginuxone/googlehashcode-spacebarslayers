using System;
using System.Collections.Generic;
using GoogleHashCode;

class Intersezione {
    String id;
    List<Strada> l_strade_in;
    List<Strada> l_strade_out;

    public Intersezione (String id) {
        this.id = id;
    }

    public void addStradaIN (Strada s) {
        l_strade_in.Add(s);
    }
    public void addStradaout (Strada s) {
        l_strade_out.Add(s);
    }

}