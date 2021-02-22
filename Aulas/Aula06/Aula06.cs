// Formatando a saída no console

using System;

class Aula06 {

    static void Main(){

        int n1, n2, n3;

        n1 = 10; n2 = 20; n3 = 30;

        // Quebras de linha: \n
        // Tabulação \t
        Console.WriteLine("Primeira forma -> valor de n1 = " + n1 + ", valor de n2 = " + n2 + ", valor de n3 = " + n3);
        Console.WriteLine("Segunda forma -> valor de n1 = {0}, valor de n2 = {1}, valor de n3 = {2}", n1,n2,n3);


        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";
        
        valorVenda = valorCompra + (valorCompra*lucro);

        Console.WriteLine("Produto...............:{0,15}", produto);
        Console.WriteLine("Valor da Compra.......:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro.................:{0,15:p}", lucro);
        Console.WriteLine("Valor da Venda........:{0,15:c}", valorVenda);

    }

}