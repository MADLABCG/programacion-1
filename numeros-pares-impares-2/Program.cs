// See https://aka.ms/new-console-template for more information
Console.WriteLine("Programacion 1 - Ejercicio 1");


// Estructuras de Control
// (Bucle) Loops ->for<-  ->while<-  ->do while<-
// IF, ELSE 

//Cuantos numeros pares, y cuantos numeros impares tenemos entre 2 numeros dados

//Declarar variables
int numero_inicial = 2;
int numero_final = 12;
int pares = 0;
int impares = 0;

for (int i = numero_inicial; i <= numero_final; i++)
{
    //numero es par cuando la division entre 2 es exacta
    // Modulo % = devuelve el residuo de una division
    if(i % 2 == 0) {
        //El numero par
        Console.WriteLine("El numero: " + i + " es par");
        pares++;
    } else {
        //El numero es impar
        Console.WriteLine("El numero: " + i + " es impar");
        impares++;
    }
}

Console.WriteLine("Numeros Pares: " + pares);
Console.WriteLine("Numeros Impares: " + impares);
