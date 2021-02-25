using System;
using System.Collections.Generic;
using GoogleHashCode;

class Intersezione {
    String id;
    List<Strada> l_strade;

    public Intersezione (String id, List <Strada> l) {
        this.id = id;
        l_strade = l;
    }

    public void add (Strada s) {
        l_strade.add(s);
    }

}