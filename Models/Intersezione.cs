using System;
using System.Collections.Generic;
using GoogleHashCode;

class Intersezione {
    public int id;
    public List<Strada> l_strade_in= new List<Strada>();
    public List<Strada> l_strade_out= new List<Strada>();

    public Intersezione (int id) {
        this.id = id;
    }

    public void addStradaIN (Strada s) {
        l_strade_in.Add(s);
    }
    public void addStradaout (Strada s) {
        l_strade_out.Add(s);
    }

}