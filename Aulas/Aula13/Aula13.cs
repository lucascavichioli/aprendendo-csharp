//Condicionais IF-ELSE
using System;

class Aula13 {

    static void Main(){

        int num = 10;
        int num2 = 12;

        if(num > num2){
            Console.WriteLine("Num é menor que {0}", num2);
        }else if(num2 > num){
            Console.WriteLine("Num2 é maior que {0}", num);
        } else {
            Console.WriteLine("Números iguais");
        }

    }

}