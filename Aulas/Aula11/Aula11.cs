// Conversões de tipos (typecast)
using System;


class Aula11 {

    static void Main(){

        int n1 = 10, vInt=300;
        short vShort= (short)vInt;
        
        float n3 = 3.5f;
        
        //Conversão implícita 
        float n2 = n1;

        //Conversão explícita
        int n4 = (int)n3;

        Console.WriteLine(n2);
        Console.WriteLine(n4);
        Console.WriteLine(vShort);

    }

}