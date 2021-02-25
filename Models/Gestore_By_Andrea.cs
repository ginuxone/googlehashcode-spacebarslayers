using System;
using System.Collections.Generic;
using GoogleHashCode;

namespace GoogleHashCode{
class Gestore_Traffico {
    public List <Intersezione> lista_Intersezioni = new List <Intersezione>();

    public List <Macchina> lista_MacchineTragitto = new List<Macchina> ();
    public int durataSimulazione;

    public int score;
    public Gestore_Traffico (int durataSimulazione, List<Intersezione> listIntersezioni) {
        score = 0;
        this.durataSimulazione= durataSimulazione;
        this.lista_Intersezioni = listIntersezioni;
    }

    public void addIntersezione (Intersezion i) {
        lista.Add(i);
    }

    public void run () {
        while (durataSimulazione >= 0) {
            List <Macchina> tempTrag = new List<Macchina> ();
            List <Macchina> tempSem = new List<Macchina> ();

            foreach (Intersezione i in lista_Intersezioni) {
                Semaforo* maxP_Semaforo= null; 
                foreach (Strada s in i.l_strade_in) {
                    s.semaforo.stato = false;

                    if (maxP_Semaforo == null || *maxP_Semaforo.priorita < s.semaforo.priorita) 
                        *maxP_Semaforo = s.semaforo;
                }
                
                *maxP_Semaforo.stato= true;
                *maxP_Semaforo.TVerde ++;
                *maxP_Semaforo.coda.Items(0).passaSemaforo();
                if (*maxP_Semaforo.coda.Items(0).stimato!= -1)
                    tempTrag.Add(*maxP_Semaforo.coda.Items(0));
                else 
                    score += durataSimulazione;

                *maxP_Semaforo.coda.pop();
            }

            foreach (Macchina m in lista_MacchineTragitto) {
                m.prosegui();
                if (m.stimato == 0) {
                    tempSem.Add(m);
                    lista_MacchineTragitto.Remove(m);
                }
            }

            foreach (Macchina m in tempTrag) {
                lista_MacchineTragitto.Add(m);            
            }

            foreach (Macchina m in tempSem) {
                m.percorso.Items(0).semaforo.coda.Add(m);                   
            }
            --durataSimulazione;
        }
        Console.WriteLine("score : " + score);
    }
}
}