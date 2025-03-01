// See https://aka.ms/new-console-template for more information
Console.WriteLine("Metodos o Funciones");

//Modificadores de Acceso son 2: private y public

//Ejecucion
Ejecutar();


//Numero 1
Boolean CompararNumeros(int numero1, int numero2)
{
    bool resultado = numero1 == numero2;
    return resultado;
}

//Numero 2
int SumarNumeros(int numero1, int numero2)
{
    int resultado = numero1 + numero2;
    return resultado;
}

//Numero 3
int RestarNumeros(int numero1, int numero2)
{
    int resultado = numero1 - numero2;
    return resultado;
}

//Numero4
Boolean NumeroPar(int numero)
{
    bool resultado = numero % 2 == 0;
    return resultado;
}

void Ejecutar()
{
    //Restar
    Console.WriteLine("Resta = " + RestarNumeros(10, 2));
    //Restar
    Console.WriteLine("Resta = " + RestarNumeros(100, 2));
    //Sumar
    Console.WriteLine("Sumar = " + SumarNumeros(20, 30));
    //Sumar
    Console.WriteLine("Sumar = " + SumarNumeros(10, 10));
    //Comparar Numeros
    Console.WriteLine("Comparar = " + CompararNumeros(10, 20));
    //Numero Par
    Console.WriteLine("Numero es Par = " + NumeroPar(33));
}

