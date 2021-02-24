// loop while
// normalmente usado quando não sabemos o tamanho do array
using System;


class Aula20 {

    static void Main(){

        int[] num = new int[10];
        

        //poderá ser usado com decremento, neste caso adicionar num.Length-1s
        int i=0;
        while(i < 3){
            num[i] = 1+i;
            Console.WriteLine("Passando aqui pela {0} vez. Valor do array {1}", i, num[i]);
            i++;
        }        

    }

}