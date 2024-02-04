// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Threading;

inicio:
Console.WriteLine("Calculadora Multiple");

int opcion;

Console.WriteLine(" - Opcion 1: Calculadora de Porcentaje");
Console.WriteLine(" - Opcion 2: Calculadora de ITBIS");
Console.WriteLine(" - Opcion 3: Salir del Programa");
Console.WriteLine("Escriba el numero de la opcion deseada: ");

try
{
    opcion = Int16.Parse(Console.ReadLine());
} catch
{
    Console.WriteLine("Opcion Invalida");
    goto inicio;
}


if (opcion == 1 )
{
    Console.WriteLine("Calculadora de Porcentaje");

    double porcentaje;
    double monto;
    double resultado;

    solicitar_porcentaje:
    Console.Write("Por Favor deme el porcentaje a aplicar: ");
    try {
        porcentaje = double.Parse(Console.ReadLine());
    } catch {
        Console.WriteLine("Porcentaje Invalido");
        goto solicitar_porcentaje;
    }
    
    solicitar_monto:
    Console.Write("Por Favor deme el monto a cual calcular el porcentaje: ");
    try {
        monto = double.Parse(Console.ReadLine());
    } catch {
        Console.WriteLine("Monto Invalido");
        goto solicitar_monto;
    }

    resultado = monto * (porcentaje / 100);

    Console.WriteLine($" Porcentaje Aplicado: {porcentaje}");
    Console.WriteLine($" Monto a calcular: {monto}");
    Console.WriteLine($" Resultado: {resultado}");
    goto inicio;
}

if(opcion == 2 )
{
    Console.WriteLine("Calculadora de ITBIS");

    string nombre;
    double precio;
    double itbis;
    double total;

    Console.Write("Por Favor deme el nombre del articulo: ");
    nombre = Console.ReadLine();

    solicitar_precio:
    Console.Write("Por Favor deme el precio del articulo: ");
    try {
        precio = double.Parse(Console.ReadLine());
    } catch {
        Console.WriteLine("Precio Invalido");
        goto solicitar_precio;
    }
    

    itbis = precio * 0.18;
    total = itbis + precio;

    Console.WriteLine($" Articulo: {nombre}");
    Console.WriteLine($" Precio: {precio}");
    Console.WriteLine($" ITBIS: {itbis}");
    Console.WriteLine($" Total: {total}");
    goto inicio;
}

if( opcion == 3 )
{
    Console.WriteLine("Saliendo del Sistema");
    Environment.Exit(99);
}

if(opcion >= 4)
{
    Console.WriteLine("Opcion Seleccionada no existe");
    goto inicio;
}

