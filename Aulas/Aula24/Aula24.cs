// Métodos
using System;

class Aula24 {

    static void Main(){
        olaMundo();
        int v1 = int.Parse(Console.ReadLine());
        int v2 = int.Parse(Console.ReadLine());
        soma(v1, v2, "O café está acabando");

        int m = multiplica(v1, v2);
        Console.WriteLine("A múltiplicação desses valores é: {0}", m);
    }

    static void olaMundo(){
        Console.WriteLine("HelloWorld!!");
    }

    static void soma(int n1, int n2, string texto=""){
        int res = n1 + n2;
        Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);
        Console.WriteLine(texto);
    }

    static int multiplica(int n1, int n2, string texto=""){
        int res = n1 * n2;
        return res;
    }

}