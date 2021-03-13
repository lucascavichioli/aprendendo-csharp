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
    public void setRodas(int rodas){
        this.rodas += rodas;

        if(this.rodas < 0){
            this.rodas = 0; 
        }else if( this.rodas > 20){
            this.rodas = 20;
        }
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

class CarroCombate : Carro {
    
    public int municao;
    public CarroCombate() : base("Carro de combate", "Verde") {
        municao = 10;
        setRodas(6);

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

        CarroCombate cc1 = new CarroCombate();
        Console.WriteLine(cc1.nome);
        Console.WriteLine(cc1.cor);
        Console.WriteLine(cc1.getRodas());
        Console.WriteLine(cc1.velMax);
        Console.WriteLine(cc1.getLigado());
    }

}