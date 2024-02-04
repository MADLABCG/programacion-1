Console.WriteLine("Programacion 1 - Ejercicio 1");

int pares = 0;
int impares = 0;
for (int i = 1; i <= 12; i++)
{
   pares += i % 2 == 0 ? 1 : 0;
   impares += i % 2 == 0 ? 0 : 1;
   Console.WriteLine(i % 2 == 0 ? "Numero " + i + " es par" : "Numero " + i + " es impar");
}
Console.WriteLine("Numeros Pares: " + pares);
Console.WriteLine("Numeros Impares: " + impares);