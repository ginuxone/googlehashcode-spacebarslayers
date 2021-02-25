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
            fillData(firstLine,DurataSimulazione,n_Intersezioni);
            runSimulation();
        }
        private static void fillData(bool firstLine,int DurataSimulazione,int n_Intersezioni){
            foreach (String line in System.IO.File.ReadLines("./InputFile/a.txt"))
            {

                if(firstLine){
                    Console.WriteLine("First Line modddafoka");
                    firstLine=false;
                    DurataSimulazione=int.Parse(line.Split(" ")[0]);
                }
            }
        }
        private static void runSimulation(){

        }
    }
}
