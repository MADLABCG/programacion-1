// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Operadores");

Boolean mayor_que = false;
Boolean menor_que = false;
Boolean igual_que = false;
Boolean mayor_igual_que = false;
Boolean menor_igual_que = false;
Boolean diferente_que = false;
Boolean resultado_AND = false;
Boolean resultado_OR = false;
Boolean resultado_NOT = false;

int numero1 = 5;
int numero2 = 10;


titulo();
bloque2();
bloque1();
bloque3();
bloque_resultado2();
bloque_resultado1();
bloque_resultado3();

 void bloque1()
{
    mayor_que = numero1 > numero2;
    menor_que = numero1 < numero2;
    igual_que = numero1 == numero2;
}

void bloque2()
{
    mayor_igual_que = numero1 >= numero2;
    menor_igual_que = numero1 <= numero2;
    diferente_que = numero1 != numero2;
}

void bloque3()
{
    resultado_AND = numero1 > numero2 && numero1 < numero2;
    resultado_OR = numero1 > numero2 || numero1 < numero2;
    resultado_NOT = !(numero1 > numero2);
}

void titulo()
{
    Console.WriteLine("En Base a los numeros: ");
    Console.WriteLine("Numero 1: " + numero1);
    Console.WriteLine("Numero 2: " + numero2);
}

void bloque_resultado1()
{
    Console.WriteLine("Mayor Que (numero1 > numero2) : " + mayor_que);
    Console.WriteLine("Menor Que (numero1 < numero2) : " + menor_que);
    Console.WriteLine("Igual Que (numero1 == numero2) : " + igual_que);
}


void bloque_resultado2()
{
    Console.WriteLine("Mayor o Igual Que (numero1 >= numero2) : " + mayor_igual_que);
    Console.WriteLine("Menor o Igual Que (numero1 <= numero2) : " + menor_igual_que);
    Console.WriteLine("Diferente Que (numero1 != numero2) : " + diferente_que);
}

void bloque_resultado3()
{
    Console.WriteLine("Resultado AND (numero1 > numero2) && (numero1 < numero2) : " + resultado_AND);
    Console.WriteLine("Resultado OR (numero1 > numero2) || (numero1 < numero2) : " + resultado_OR);
    Console.WriteLine("Resultado NOT !(numero1 > numero2) : " + resultado_NOT);
}



