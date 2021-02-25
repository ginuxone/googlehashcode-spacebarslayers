using System;

namespace GoogleHashCode
{
    class Strada
    {
        public int nome;
        public Semaforo semaforo;
        public int TPercorrenza;
        public Intersezione inizio;
        public Intersezione fine;

        public Strada(int nome,Semaforo semaforo, int TPercorrenza,Intersezione inizio, Intersezione fine) {
            this.nome=nome;
            this.semaforo=semaforo;
            this.TPercorrenza=TPercorrenza;
            this.inizio=inizio;
            this.fine=fine;
        }
    }
}