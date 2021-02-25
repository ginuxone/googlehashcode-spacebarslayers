using System.Collections;

namespace GoogleHashCode
{
    class OutputCreator
    {
        private string prima_riga;
        private List<List<string>> righe_semaforo_singolo;
        public OutputCreator(int numero_di_incroci_gestiti)
        {
            this.prima_riga = numero_di_incroci_gestiti;
            righe_semaforo_singolo = new List<List<string>>();
        }
        public void AddProgrammaIntersezione(Intersezione intersezione)
        {
            List<string> programma_intersezione = new List<String>();
            programma_intersezione.Add(intersezione.id);
            programma_intersezione.Add(intersezione.l_strade_in.Count);
            foreach (Strada strada in intersezione.l_strade_in)
            {
                programma_intersezione.Add(strada.nome + strada.semaforo.TVerde);
            }
            this.righe_semaforo_singolo.Add(programma_intersezione);
        }
        public string[] GeneraOutput()
        {
            List<String> outputList = new List<String>();
            outputList.Add(this.prima_riga);
            foreach (List<string> programma_singolo in this.righe_semaforo_singolo)
            {
                foreach (string riga in programma_singolo)
                {
                    outputList.Add(riga);
                }
            }
            return outputList.ToArray();
        }
    }
}