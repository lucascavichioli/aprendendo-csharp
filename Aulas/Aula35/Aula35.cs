//cadeia de herança e construtor da classe base
using System;

class Veiculo { // classe base
    public int velMax;
    public bool ligado;
    private int rodas;

    public Veiculo(int rodas){
        this.rodas = rodas;
    }

    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }

    public string getLigado(){
        return (ligado ? "Sim" : "Não");
    }

    public int getRodas(){
        return rodas;
    }
}

class Carro : Veiculo { //classe derivada
    public string nome;
    public string cor;
    public Carro(string nome, string cor) : base(4) {
        velMax = 140;
        this.nome = nome;
        this.cor = cor;
    }

    ~Carro(){
        desligar();
    }
}

class Aula35 {

    static void Main(){

        Carro c1 = new Carro("Fuscão", "Preto");
        c1.ligar();

        Console.WriteLine(c1.ligado);
        Console.WriteLine(c1.nome);
        Console.WriteLine(c1.cor);
        Console.WriteLine(c1.getRodas());
        Console.WriteLine(c1.velMax);
        Console.WriteLine(c1.getLigado());

    }

}