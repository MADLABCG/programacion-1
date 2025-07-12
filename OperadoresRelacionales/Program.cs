// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores Relacionales");


// Operadores Relacionales
// Son aquellos que nos permiten comparar dos valores y obtener un resultado booleano.
// > Mayor que
// < Menor que
// >= Mayor o igual que
// <= Menor o igual que
// == Igual que
// != Diferente de

int numero1 = 20;
int numero2 = 20;
Console.WriteLine("Operaciones con los numeros: " + numero1 + " y " + numero2);

bool mayorQue = numero1 > numero2;
bool menorQue = numero1 < numero2;
bool mayorOIgualQue = numero1 >= numero2;
bool menorOIgualQue = numero1 <= numero2;
bool igualQue = numero1 == numero2;
bool diferenteDe = numero1 != numero2;

Console.WriteLine("numero1 > numero2: " + mayorQue);
Console.WriteLine("numero1 < numero2: " + menorQue);
Console.WriteLine("numero1 >= numero2: " + mayorOIgualQue);
Console.WriteLine("numero1 <= numero2: " + menorOIgualQue);
Console.WriteLine("numero1 == numero2: " + igualQue);
Console.WriteLine("numero1 != numero2: " + diferenteDe);