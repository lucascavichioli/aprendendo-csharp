// Classes e Objetos
using System;

public class Jogador {

    public int idade = 0;
    public string nome = "";
    public int energia = 100;
    private bool vivo = true;

    public bool estaVivo(){
        return this.vivo;
    }

}

class Aula28 {

    static void Main(){
        Jogador jogador1 = new Jogador();
        Jogador jogador2 = new Jogador();

        jogador1.nome = "Lucas";
        jogador1.idade = 23;
        jogador1.energia = 60;

        Console.WriteLine("Nome do jogador 1: {0}", jogador1.nome);
        Console.WriteLine("Idade do jogador 1: {0}", jogador1.idade);
        Console.WriteLine("Energia do jogador 1: {0}", jogador1.energia);
        Console.WriteLine(jogador1.estaVivo());
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Energia do jogador 2: {0}", jogador2.energia);
    }

}