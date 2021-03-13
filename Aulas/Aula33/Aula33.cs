// public vs private
using System;

class Jogador {
    private int energia;
    private string nome;

    public Jogador(string nome){
        this.nome = nome;
        energia = 100;
    }

    public int getEnergia(){
        return this.energia;
    }

    public string getNome(){
        return this.nome;
    }

    public void setEnergia(int e){       
        this.energia += e;

        if(this.energia < 0){
            this.energia = 0;
        }else if(this.energia > 100){
            this.energia = 100;
        }
    }
}

class Aula33 {
    static void Main(){
        Jogador j1 = new Jogador("Lucas");
        j1.setEnergia(-50);

        j1.setEnergia(25);

        Console.WriteLine("Nome: {0}", j1.getNome());
        Console.WriteLine("Nome: {0}", j1.getEnergia());
    }

}