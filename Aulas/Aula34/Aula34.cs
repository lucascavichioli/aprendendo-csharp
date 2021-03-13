//herança
using System;

class Veiculo { // classe base
    public int velMax;
    public bool ligado;
    public int rodas;

    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }

    public string getLigado(){
        if(ligado){
            return "Sim";
        }else{
            return "Não";
        }
    }
}

class Carro : Veiculo { //classe derivada
    public string nome;
    public string cor;
    public Carro(string nome, string cor){
        rodas = 4;
        velMax = 140;
        this.nome = nome;
        this.cor = cor;
    }

    ~Carro(){
        desligar();
    }
}

class Aula34 {

    static void Main(){

        Carro c1 = new Carro("Fuscão", "Preto");
        c1.ligar();

        Console.WriteLine(c1.ligado);
        Console.WriteLine(c1.nome);
        Console.WriteLine(c1.cor);
        Console.WriteLine(c1.rodas);
        Console.WriteLine(c1.velMax);
        Console.WriteLine(c1.getLigado());

    }

}