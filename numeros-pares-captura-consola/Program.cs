// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio de Numeros Pares");

Console.Beep();
int numero_inicial = -1;
int numero_final = -2;

do
{
    //Intenta
    try { 
        //Bucles (Loops)
        Console.WriteLine("Introduzca numero Inicial positivo:");
        numero_inicial = Convert.ToInt32(Console.ReadLine());
    }
    catch {
        //Captura
        Console.WriteLine("Numero Inicial No Valido, Intente nuevamente");
    }
} while (numero_inicial < 0);

do
{
    //Intenta
    try
    {
        //Bucles (Loops)
        Console.WriteLine("Introduzca numero Final mayor al numero inicial:");
        numero_final = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        //Captura
        Console.WriteLine("Numero Final No Valido, Intente nuevamente");
    }
} while (numero_final < numero_inicial);

int for_pares = 0;
int for_impares = 0;
int while_pares = 0;
int while_impares = 0;
int dowhile_pares = 0;
int dowhile_impares = 0;

//For Loop
//para un numero llamado i, que mientras sea menor que un numero llamado numero_final, mantente incrementando en 1 el valor de i y ejecuta....
Console.WriteLine("For Loop");
for (int i = numero_inicial; i <= numero_final; i++)
{
    //Si el numero i dividido entre 2 y no tiene residuo entonces es par
    if(i % 2 == 0) {
        Console.WriteLine("El numero " + i + " es par");
        //Incrementa en 1 el valor de la variable par si el numero es par
        for_pares++;
    
    //De lo contrario
    } else {
        Console.WriteLine("El numero " + i + " es impar");
        //Incrementa en 1 el valor de la variable impar si el numero no es par
        for_impares++;
    }
}

//while Loop
//Mientras variable numero_while sea menor o igual a la variable de numero_final sea verdadero ejecuta.....
Console.WriteLine("While Loop");
int numero_while = numero_inicial;
while (numero_while <= numero_final)
{
    //Si el numero i dividido entre 2 y no tiene residuo entonces es par
    if (numero_while % 2 == 0)
    {
        Console.WriteLine("El numero " + numero_while + " es par");
        //Incrementa en 1 el valor de la variable par si el numero es par
        while_pares++;

        //De lo contrario
    }
    else
    {
        Console.WriteLine("El numero " + numero_while + " es impar");
        //Incrementa en 1 el valor de la variable impar si el numero no es par
        while_impares++;
    }
    numero_while++;
}


//Do While Loop
Console.WriteLine("Do While Loop");
int numero_doWhile = numero_inicial;
//Ejecuta ......
do {
    //Si el numero i dividido entre 2 y no tiene residuo entonces es par
    if (numero_doWhile % 2 == 0)
    {
        Console.WriteLine("El numero " + numero_doWhile + " es par");
        //Incrementa en 1 el valor de la variable par si el numero es par
        dowhile_pares++;

        //De lo contrario
    }
    else
    {
        Console.WriteLine("El numero " + numero_doWhile + " es impar");
        //Incrementa en 1 el valor de la variable impar si el numero no es par
        dowhile_impares++;
    }
    numero_doWhile++;
//Mientras numero_doWhile sea menor o igual al numero final
} while (numero_doWhile <= numero_final);


Console.WriteLine("Sumarizado de los Loops");
Console.WriteLine("En el bucle for hay " + for_pares + " numeros pares y "+ for_impares + " numeros impares");
Console.WriteLine("En el bucle while hay " + while_pares + " numeros pares y " + while_impares + " numeros impares");
Console.WriteLine("En el bucle doWhile hay " + dowhile_pares + " numeros pares y " + dowhile_impares + " numeros impares");
Console.WriteLine("Presione cualquier tecla para terminar...");
Console.ReadKey();