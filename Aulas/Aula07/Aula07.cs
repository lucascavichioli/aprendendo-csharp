// Constantes
using System;

class Aula07{
    static void Main(){
        const string nome = "Lucas";
        const double pi = 3.1415;

        //Erro ao alterar constante
        //nome = "NovoNome";

        Console.WriteLine("> Nome: {0}", nome);
        Console.WriteLine("> Valor de PI: {0}", pi);
    }
}