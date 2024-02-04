// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

// > >=  < <=  !=
// 

if((10 != 90) && (1 == 1)) {
    verdadero();
} else {
    falso();
}

if ((10 != 90) && (1 != 1))
{
    verdadero();
}
else
{
    falso();
}

void verdadero()
{
    System.Console.WriteLine("Es Verdadero");
}

void falso()
{
    System.Console.WriteLine("Es Falso");
}