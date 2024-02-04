// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Calculadora de ITBIS");

// Hacer un programa que solicite:
// El nombre de un articulo
// El precio de un articulo
// Que ejecute:
// Calcular el ITBIS del articulo
// Que retorne:
// El nombre del articulo
// El ITBIS del articulo
// El precio mas el ITBIS



string nombre;
double precio;
double itbis;
double total;

Console.Write("Por Favor deme el nombre del articulo: ");
nombre = Console.ReadLine();

Console.Write("Por Favor deme el precio del articulo: ");
precio = double.Parse(Console.ReadLine());

itbis = precio * 0.18;
total = itbis + precio;

Console.WriteLine($" Articulo: {nombre}");
Console.WriteLine($" Precio: {precio}");
Console.WriteLine($" ITBIS: {itbis}");
Console.WriteLine($" Total: {total}");

