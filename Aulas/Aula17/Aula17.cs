// Array / Vetor
using System;
class Aula17 {

    static void Main(){

        //declaração
        int[] nomeArray = new int[5];
        string[] times = new string[2];

        //declaração com atribuição
        int[] num = new int[3]{55,77,99};
        
        //usa o número de elementos adicionados como tamanho do array
        int[] num2 = {55,77,99};

        times[0] = "Flamengo";
        times[1] = "Internacional";


        nomeArray[0] = 11;
        nomeArray[1] = 22;
        nomeArray[2] = 33;
        nomeArray[3] = 44;
        nomeArray[4] = 55;

        Console.WriteLine(nomeArray[2]);
        Console.WriteLine(times[0]);

    }

}