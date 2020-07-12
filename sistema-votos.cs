using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int can1 = 0; int can2 = 0; int can3 = 0; int can4 = 0;
            Random rand = new Random();
            
            Console.WriteLine("Candidato 1: Gonzalo Castillo, Aspira a: Presidente, Partido: Partido Azul(PA) fundado en 1923");
            Console.WriteLine("Candidato 2: Luis Abinader, Aspira a: Presidente, Partido: Partido Rojo(PR) fundado en 1925");
            Console.WriteLine("Candidato 3: Leonel Fernandez, Aspira a: Presidente, Partido: Partido Morado(PM) fundado en 1924");
            Console.WriteLine("Candidato 4: Guillermo Moreno, Aspira a: Presidente, Partido: Partido Verde(PV) fundado en 1917");
            
            
            for(int i = 1; i <=1000; i++){
                int voto = rand.Next(1,5);
                if(voto == 1){ can1++; }
                if(voto == 2){ can2++; }
                if(voto == 3){ can3++; }
                if(voto == 4){ can4++; }
            }
            int total = can1 + can2 + can3 + can4;
            Console.WriteLine();
            
            int[] list = {can1, can2, can3, can4};
            Array.Sort(list);
              
         for(int i = 0; i < list.Length; i++) {
             if(list[3 - i] == can1){
                 Console.WriteLine("Candidato 1: " + can1.ToString() + " votos, para un % de: " + (can1 * 0.1000).ToString());
             }
              if(list[3 - i] == can2){
                 Console.WriteLine("Candidato 2: " + can2.ToString() + " votos, para un % de: " + (can2 * 0.1000).ToString());
             }
              if(list[3 - i] == can3){
                 Console.WriteLine("Candidato 3: " + can3.ToString() + " votos, para un % de: " + (can3 * 0.1000).ToString());
             }
              if(list[3 - i] == can4){
                  Console.WriteLine("Candidato 4: " + can4.ToString() + " votos, para un % de: " + (can4 * 0.1000).ToString());
             }
         }
            Console.WriteLine("Total de votos: " + total.ToString());
            
        }
    }
}
