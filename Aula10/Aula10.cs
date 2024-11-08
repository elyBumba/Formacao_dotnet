using System;


//08-11-2024
// Enumeradores (enum)

class Aula9{

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado};
    static void Main(){

        //DiasSemana ds = DiasSemana.Domingo;
       // DiasSemana ds = (DiasSemana)3;
        int ds = (int)DiasSemana.Sexta; //retorna o indice


        Console.WriteLine(ds);

    }

}