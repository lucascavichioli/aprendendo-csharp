// Enumeradores (enum)

using System;

class Aula10 {

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    enum HorariosDisponiveis{};
    static void Main(){

        //DiasSemana ds = DiasSemana.Domingo;
        //DiasSemana ds = (DiasSemana)3;

        int ds = (int)DiasSemana.Sábado;

        Console.WriteLine(ds);

    }

}