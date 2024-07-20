//Inicio del programa PASO 1
Console.WriteLine("Programa para sumar dos Numeros");


// Solicita el primer número al usuario PASO 2
Console.WriteLine("Introduce el primer número:");
string input1 = Console.ReadLine();

// Convierte el primer número a un tipo numérico
int numero1;
while (!int.TryParse(input1, out numero1))
{
    Console.WriteLine("Por favor, introduce un número válido:");
    input1 = Console.ReadLine();
}

// Solicita el segundo número al usuario PASO 3
Console.WriteLine("Introduce el segundo número:");
string input2 = Console.ReadLine();

// Convierte el segundo número a un tipo numérico
int numero2;
while (!int.TryParse(input2, out numero2))
{
    Console.WriteLine("Por favor, introduce un número válido:");
    input2 = Console.ReadLine();
}

// Suma los dos números PASO 4
int suma = numero1 + numero2;


// Muestra el resultado de la suma en la consola PASO 5
Console.WriteLine("La suma de {0} y {1} es: {2}", numero1, numero2, suma);

// Espera a que el usuario presione una tecla antes de cerrar
Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();