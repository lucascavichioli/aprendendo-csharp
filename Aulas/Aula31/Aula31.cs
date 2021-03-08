// Classes static
using System;
static public class Jogador {

    static public int energia;

    static public string nome;

    static public int idade;

    static private bool vivo;
    
    //Constutor
    static public void iniciar(string n){
        energia = 100;
        vivo = true;
        nome = n;
        idade = 20;
    }
    static public void info(){
        Console.WriteLine("Nome do jogador: {0}", nome);
        Console.WriteLine("Idade do jogador: {0}", idade);
        Console.WriteLine("Energia do jogador: {0}", energia);
        Console.WriteLine("O jogador está vivo?: {0}", vivo);
    }

}

class Inimigo{

    static public bool alerta;
    public string nome;

    public Inimigo(string n){
        alerta=false;
        nome = n;
    }

    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("------------------");
    }

}

class Aula31{
    static void Main(){

        Jogador.iniciar("Lucas");
        Jogador.info();

        Inimigo i1 = new Inimigo("Lucas");
        Inimigo i2 = new Inimigo("João");
        Inimigo i3 = new Inimigo("Malu");

        Inimigo.alerta = true;
        
        i1.info();
        i2.info();
        i3.info();

    }

}