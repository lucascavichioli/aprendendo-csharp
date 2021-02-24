// loop for
using System;

class Aula18{
    static void Main(){

        int[] num = new int[10];

        for(int i = 1; i <= 3; i++){
            Console.WriteLine("Passando aqui pela {0} vez", i);
        }

        // tomar cuidado com o tamanho do array
        for(int i = 0; i < num.Length; i++){
            num[i] = 1+(i*2);
            Console.WriteLine("Valor do elemento do array: {0}", num[i]);
        }
    }
}