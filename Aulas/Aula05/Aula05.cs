// Operadores e Operações
using System;

class Aula05 {

    static void Main(){

        // > < >= <=
        // != ==
        int res = (10 + 5) * 2;

        bool res2 = 10 < 5;

        int res3 = 10;

        // + - / *
        res3 = res3 + 1;
        res3+=1;
        res3++;

        // & = AND / E
        // | = OR / Ou
        bool res4 = (5 > 3)|(10 < 4);

        Console.WriteLine("> " + res);
        Console.WriteLine("> " + res2);
        Console.WriteLine("> " + res3);
        Console.WriteLine("> " + res4);
    }

}