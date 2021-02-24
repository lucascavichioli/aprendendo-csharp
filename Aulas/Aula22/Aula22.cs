// loop foreach
using System;

class Aula22 {

    static void Main(){

        int[] num = new int[3]{11,22,33};

        int[,] matriz = new int[2,2]{{2,3}, {10,15}};

        /* for(int i=0; i < num.Length; i++){
            Console.WriteLine(num[i]);
        } */

        foreach(int n in num){
            Console.WriteLine(n);
        }     

        //recomendado usar o for para matrizes, pois possui mais controle
        foreach(var m in matriz) {
            Console.WriteLine(m);
        }      

    }

}