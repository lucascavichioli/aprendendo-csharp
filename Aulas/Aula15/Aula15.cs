//SWITCH CASE
using System;

class Aula15{

    static void Main(){

        int tempo = 0;
        char escolha;

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte:[a]=Avião | [c]Carro | [o]Ônibus");

        escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            //para capturar caracteres minúsculos e maiúsculos 
            case 'a' : 
            case 'A' : 
                tempo = 50;
                break;
            case 'c' : 
                tempo = 480;
                break;
            case 'o' : 
                tempo = 700;
                break;
            default : 
                tempo = -1;
                break;
        }

        if(tempo < 0){
            Console.WriteLine("Transporte indisponível");
        }else{
            Console.WriteLine("O tempo da sua viagem é: {0}", tempo);
        }

    }

}