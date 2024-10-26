bool isError = false;

inicio:
if (isError)
{
    Console.WriteLine("Opcion Invalida");
    isError = false;
}
Console.WriteLine("Calculadora Simple");

int opcion;

Console.WriteLine("Opcion 1: Sumar");
Console.WriteLine("Opcion 2: Restar");
Console.WriteLine("Opcion 3: Dividir");
Console.WriteLine("Opcion 4: Multiplicar");
Console.WriteLine("Escriba el numero de la opcion deseada");


try
{
    opcion = int.Parse(Console.ReadLine());
}
catch
{
    Console.Clear();
    isError = true;
    goto inicio;
}

if (opcion == 1)
{
    double numero1;
    double numero2;

solicitar_numero1:
    Console.WriteLine("Por favor entre primer numero a sumar");
    try
    {
        numero1 = double.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Favor digite un numero");
        goto solicitar_numero1;
    }

solicitar_numero2:
    Console.WriteLine("Por favor entre segundo numero a sumar");
    try
    {
        numero2 = double.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Favor digite un numero");
        goto solicitar_numero2;
    }

    Console.WriteLine("Resultado: " + sumar(numero1, numero2));
}

double sumar(double x, double y)
{
    return x + y;
}

double restar(double minuendo, double sustraendo)
{
    return minuendo - sustraendo;
}

double division(double dividendo, double divisor)
{
    return dividendo / divisor;
}

double multiplicar(double x, double y)
{
    return x * y;
}

