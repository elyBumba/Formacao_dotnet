using System;

//08-11-2024
// Lendo valores do teclado

class Aula08{
    static void Main()
    { 
        int v1,v2, soma, num1,num2;
       // string nome;
        //Console.Write("Escreve o seu nome:"); 
        //nome = Console.ReadLine();
        //Console.WriteLine("Nome digitado: "+nome);

         Console.WriteLine("Insira o primeiro numero: ");
         num1=int.Parse(Console.ReadLine());

         Console.WriteLine("Insira o segundo numero: ");
         num2=Convert.ToInt32(Console.ReadLine());

         soma=num1+num2;

         Console.WriteLine("Resultado da soma é: {0} ", soma);
         //Console.WriteLine("Resultado da multiplicação é: " num1*num2);
    }   
}