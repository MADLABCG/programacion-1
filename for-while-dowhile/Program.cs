// See https://aka.ms/new-console-template for more information
Console.WriteLine("Programacion 1");


// Estructuras de Control
// (Bucle) Loops ->for<-  ->while<-  ->do while<-
// IF, ELSE 

//Declarar variables

int numero_inicial = 0;
int numero_final = 10;


//Cuantos numeros pares, y cuantos numeros impares tenemos entre 2 numeros dados
for (int i = 1; i <= 5; i++)
{
//Repite 10 veces
Console.WriteLine("Repeticion " +  i);
    numero_inicial++;
    numero_final--;
}

Console.WriteLine("Numero Inicial: " + numero_inicial);
Console.WriteLine("Numero Final: " + numero_final);
