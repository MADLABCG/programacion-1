// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;
using System.Threading;

Console.WriteLine("Calculadora de Porcentaje");

//Hacer un programa que solicite:
//Porcentaje a aplicar
//Numero al que se le calculara el porcentaje
//Ejecute:
//Calculo del porcentaje aplicado
//Resultado:
//Monto del porcentaje


double porcentaje;
double monto;
double resultado;

Console.Write("Por Favor deme el porcentaje a aplicar: ");
porcentaje = double.Parse(Console.ReadLine());

Console.Write("Por Favor deme el monto a cual calcular el porcentaje: ");
monto = double.Parse(Console.ReadLine());

resultado = monto * (porcentaje/100);

Console.WriteLine($" Porcentaje Aplicado: {porcentaje}");
Console.WriteLine($" Monto a calcular: {monto}");
Console.WriteLine($" Resultado: {resultado}");