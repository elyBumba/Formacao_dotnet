using System;

//08-11-2024
// Aula sobre formatacao
class Aula06{
    static void Main()
    { 
        //int n1, n2,n3;
       // n1= 10;  n2=20; n3=30;

        //\t tabulação
        //\n mudança de linha
       // Console.Write("\tn1={0},\n n2={1},\n n3={2}", n1,n2,n3);
        double valorCompra = 5.50;
        double valorVenda;
        double lucro=0.1;
        string produto="Pastel";

        valorVenda=valorCompra+(valorCompra*lucro);

        Console.WriteLine("Produto........:{0,15}",produto); //
        Console.WriteLine("ValCompra......:{0,15:c}",valorCompra);
        Console.WriteLine("Lucro..........:{0,15:p}",lucro);
        Console.WriteLine("Val.Venda......:{0,15:c}",valorVenda);

    }
}