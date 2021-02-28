//Sobrecarga de Construtores
using System;//Construtores e Destrutores
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
        idade = 20;
    }

    //construtor 2 (sobrecarga)
    public Jogador(){
        energia = 100;
        vivo = true;
        nome = "Jogador";
        idade = 18;
    }

    //construtor 3 (sobrecarga)
    public Jogador(string n, int e, int i){
        energia = e;
        idade = i;
        nome = n;
        vivo = true;
    }

    //construtor 4 (sobrecarga)
    public void info(){
        Console.WriteLine("Nome do jogador: {0}", nome);
        Console.WriteLine("Idade do jogador: {0}", idade);
        Console.WriteLine("Energia do jogador: {0}", energia);
        Console.WriteLine("O jogador está vivo?: {0}", vivo);
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


class Aula30{

    static void Main(){
        Jogador jogador1 = new Jogador();
        Jogador jogador2 = new Jogador("João");
        Jogador jogador3 = new Jogador("Lucas", 80, 50);

        jogador1.info();
        jogador2.info();
        jogador3.info();

    }

}