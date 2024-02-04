/// See https://aka.ms/new-console-template for more information
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

while(numero_inicial <= numero_final)
{
    //numero es par cuando la division entre 2 es exacta
    // Modulo % = devuelve el residuo de una division
    if (numero_inicial % 2 == 0) {
        //El numero par
        Console.WriteLine("El numero: " + numero_inicial + " es par");
        pares++;
    } else {
        //El numero es impar
        Console.WriteLine("El numero: " + numero_inicial + " es impar");
        impares++;
    }
    numero_inicial++;
}

Console.WriteLine("Numeros Pares: " + pares);
Console.WriteLine("Numeros Impares: " + impares);
