// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

int numero1 = 20;
int numero2 = 30;
int numero3 = 40;


ejecutarTodo();

void ejecucion2()
{
    Console.WriteLine("Ejecucion 2");
    if (((numero1 + numero2) > numero3) && numero3 < 100)
    {
        multiplicar();
    }
    else
    {
        sumar();
    }
}

void ejecucion1()
{
    Console.WriteLine("Ejecucion 1");
    //Voy a sumar si la afirmacion es positiva y restar si es falsa
    if (numero1 >= numero2)
    {
        sumar();
    }
    else
    {
        restar();
    }
}

void ejecutarTodo()
{
    ejecucion1();
    ejecucion2();
}

 void sumar()
{
    Console.WriteLine("Sumando: " + numero1 + numero2);
}

void restar()
{
    Console.WriteLine("Restando: " + (numero2 - numero1));
}

void multiplicar()
{
    Console.WriteLine("Multiplicando: " + numero2 * numero3);
}