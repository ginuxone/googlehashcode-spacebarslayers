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
            fillData(ref firstLine,ref DurataSimulazione,ref n_macchine,ref n_Intersezioni,ref n_streets,ref score);
            runSimulation();
        }
        private static void fillData(ref bool firstLine,ref int DurataSimulazione,ref int n_macchine,ref int n_Intersezioni,ref int n_streets,ref int score){
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
                }else{
                    
                }
            }
        }
        private static void runSimulation(){

        }
    }
}
