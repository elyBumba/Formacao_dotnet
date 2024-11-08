using System;


//08-11-2024
// Operações de Bitwise

class Aula9{
    static void Main(){

        //bitwise é o deslocamento dos bits para direita ou esquerda
        //o deslocamento para esquerda dobra o valor
        //o deslocamento para direita fica pela metade

        int num = 10;
        num = num<<1;Console.WriteLine(num); //o resultado é 20 porque por ser deslocamento a direita dobrao valor

        int num1 = 10;
        num1 = num1>>1;Console.WriteLine(num1); //o resultado é 5 porque por ser deslocamento pela esquerda, fica a metade do valor
        

    }

}