//Construtores e Destrutores
// Toda classe tem um construtor (mesmo não contendo no código o csharp irá criá-lo automaticamente)
using System;
class Jogador {

    public int energia;

    public string nome;

    public int idade;

    private bool vivo;
    
    //Constutor
    public Jogador(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }

    //destrutor
    ~Jogador(){
        Console.WriteLine("Destruindo Objeto...");
        nome = "";
        energia = 0;
        idade = 0;
        vivo = false;
    }

}


class Aula29{

    static void Main(){
        Jogador jogador1 = new Jogador("Lucas");
        Jogador jogador2 = new Jogador("João");

        //jogador1.nome = "Lucas";
        jogador1.idade = 23;
        //jogador1.energia = 60;

        Console.WriteLine("Nome do jogador 1: {0}", jogador1.nome);
        Console.WriteLine("Idade do jogador 1: {0}", jogador1.idade);
        Console.WriteLine("Energia do jogador 1: {0}", jogador1.energia);
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Nome do jogador 2: {0}", jogador2.nome);
        Console.WriteLine("Energia do jogador 2: {0}", jogador2.energia);
    }

}