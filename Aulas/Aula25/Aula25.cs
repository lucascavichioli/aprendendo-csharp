// passagem por valor e por referência
// utilizando o ref, é usado o mesmo endereço de memória
using System;

class Aula25 {

    static void Main(){
        int num = 10;
        dobrar2(ref num);
        Console.WriteLine(num);
    }

    static void dobrar1(int valor){
        valor *= 2;
    }

    static void dobrar2(ref int valor){
        valor *= 2;
    }
}