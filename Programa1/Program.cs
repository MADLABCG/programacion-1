// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Mundo!");


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Imprimiendo Indice (For) : " + i);
}

int numero = 0;
while (numero < 10)
{
    Console.WriteLine("Imprimiendo Indice (While): " + numero);
    numero++;
}

do {
    Console.WriteLine("Imprimiendo Indice (Do While): " + numero);
    numero++;
} while (numero < 10);
