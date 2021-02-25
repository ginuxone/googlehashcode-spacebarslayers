using System;
using System.Collections.Generic;
using System.Linq;

namespace GoogleHashCode
{
    class Program
    {
        static void Main(string[] args)
        {   
            bool firstLine=true;
            int DurataSimulazione=0;
            int n_Intersezioni=0;
            int n_macchine=0;
            int n_streets=0;
            int score=0;
            List<Strada> strade=new List<Strada>();
            List<Intersezione> intersezioni=new List<Intersezione>();
            List<Macchina> macchine= new List<Macchina>();
            fillData(ref firstLine,ref DurataSimulazione,ref n_macchine,ref n_Intersezioni,ref n_streets,ref score,ref strade,ref intersezioni,ref macchine);
            runSimulation();
        }
        private static void fillData(ref bool firstLine,ref int DurataSimulazione,ref int n_macchine,ref int n_Intersezioni,ref int n_streets,ref int score,ref List<Strada> strade,ref List<Intersezione> intersezioni,ref List<Macchina> macchine){
            int i=0;
            foreach (String line in System.IO.File.ReadLines("./InputFile/a.txt"))
            {
                if(firstLine){
                    Console.WriteLine("First Line modddafoka");
                    firstLine=false;
                    DurataSimulazione=int.Parse(line.Split(" ")[0]);
                    n_Intersezioni=int.Parse(line.Split(" ")[1]);
                    n_streets=int.Parse(line.Split(" ")[2]);
                    n_macchine=int.Parse(line.Split(" ")[3]);
                    score=int.Parse(line.Split(" ")[4]);
                }else if(i<n_streets){
                    int inizio=int.Parse(line.Split(" ")[0]);
                    int fine=int.Parse(line.Split(" ")[1]);
                    foreach (Intersezione intersezione in intersezioni)
                    {
                        if(intersezione.id!=inizio){
                            intersezioni.Add(new Intersezione(id:inizio));
                        }
                        if(intersezione.id!=fine){
                            intersezioni.Add(new Intersezione(id:fine));
                        }
                    }
                    strade.Add(new Strada(
                        nome:(line.Split(" ")[2]).ToString(),
                        semaforo: new Semaforo(),
                        TPercorrenza:int.Parse(line.Split(" ")[3]),
                        inizio:intersezioni.Find(i=>i.id==inizio),
                        fine:intersezioni.Find(i=>i.id==fine)
                    ));
                }else{
                    //macchine.Add(new Macchina());
                }
                i++;
            }
        }
        private static void runSimulation(){
            Console.WriteLine("Runing");
        }
    }
}
