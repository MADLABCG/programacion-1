// See https://aka.ms/new-console-template for more information


//Necesitamos Imprimir los numeros pares del 1 al 1000;



//Loop o Bucle (FOR)
Console.WriteLine("Bucle FOR");
for (int i = 11; i <= 10; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine("El numero " + i + " Es PAR");
    } else
    {
        Console.WriteLine("El numero " + i + " Es IMPAR");
    }
}

//Loop o Bucle (WHILE)
Console.WriteLine("Bucle While");
int y = 11;
while (y <= 10)
{
    y++;
    if (y % 2 == 0)
    {
        Console.WriteLine("El numero " + y + " Es PAR");
    } else
    {
        Console.WriteLine("El numero " + y + " Es IMPAR");
    }
}

//Loop o Bucle (DO WHILE)
int x = 11;
Console.WriteLine("Bucle DO WHILE");
do
{
    if (x % 2 == 0)
    {
        Console.WriteLine("El numero " + x + " Es PAR");
    }
    else
    {
        Console.WriteLine("El numero " + x + " Es IMPAR");
    }
    x++;

} while (x <= 10);
