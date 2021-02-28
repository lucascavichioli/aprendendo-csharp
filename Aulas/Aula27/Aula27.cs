// Argumento params
using System;

class Aula27 {

    static void Main(){
        soma(1, 2, 3, 4);
    }

    static void soma(params int[]n){
        int res = 0;
        
        if(n.Length < 1){
            Console.WriteLine("Não existem valores a serem somados");
        }else if(n.Length < 2){
            Console.WriteLine("Valores insuficientes para soma");
        }else{
            for (int i = 0; i < n.Length; i++)
            {
                // res = res + n[i]
                res += n[i];
            }
            Console.WriteLine("A soma dos valores é {0}", res);
        }

        
    }

}