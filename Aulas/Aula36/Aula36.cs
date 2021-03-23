using System;

class Veiculo{
    public int velAtual;
    private int VelMax;
    protected bool ligado;

    public Veiculo(int velMax){
        velAtual = 0;
        this.VelMax = velMax; 
        ligado = false;
    }

    public bool getLigado(){
        return ligado;
    }

    public int getVelMax(){
        return VelMax;
    }

}

class Carro : Veiculo {

    public string nome;
    public Carro(string nome, int vm):base(vm){
        this.nome = nome;
        ligado = true;
    }

}

class Aula36 {
    static void Main(){
        Carro carro = new Carro("Bonitão", 120);
        Console.WriteLine("Nome: {0}", carro.nome);
        Console.WriteLine("Velocidade Máxima: {0}", carro.getVelMax());
        Console.WriteLine("Ligado: {0}", carro.getLigado());
    }
}