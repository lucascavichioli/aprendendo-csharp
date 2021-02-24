// condicional IF
using System;

class Aula12 {

    static void Main(){

        int pontos = 74;
        string timeCampeao;

        Console.Write("Digite o time campeão do brasileirão 2021: ");
        timeCampeao = Console.ReadLine();        
        
        if(timeCampeao == "Flamengo" && pontos > 73){
            Console.WriteLine("Flamengo campeão!");
        }else{
            Console.WriteLine("Lost");
        }

    }

}