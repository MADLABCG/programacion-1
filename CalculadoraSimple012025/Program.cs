double numero1 = 0;
double numero2 = 0;
double resultado = 0;
int opcion = 0;
string operacion = "";

menu_inicio:
Console.WriteLine("Calculadora Simple");
Console.WriteLine("Seleccione una opción");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");
Console.WriteLine("5. Salir");

try
{
    opcion = Convert.ToInt32(Console.ReadLine());
    if (opcion == 5)
    {
        Environment.Exit(0);
    }
}
catch
{
    Console.WriteLine("Opcion Invalida");
    goto menu_inicio;
}

primer_numero:
Console.WriteLine("Ingrese el primer número");
try { 
    numero1 = Convert.ToDouble(Console.ReadLine()); 
} catch { 
    Console.WriteLine("Esto no es un numero"); 
    goto primer_numero; 
}


segundo_numero:
Console.WriteLine("Ingrese el segundo número");
try
{
    numero2 = Convert.ToDouble(Console.ReadLine());
}
catch
{
    Console.WriteLine("Esto no es un numero");
    goto segundo_numero;
}

if(opcion == 1)
{
    operacion = "Suma";
    resultado = numero1 + numero2;
}
else if (opcion == 2)
{
    operacion = "Resta";
    resultado = numero1 - numero2;
}
else if (opcion == 3)
{
    operacion = "Multiplicacion";
    resultado = numero1 * numero2;
}
else if (opcion == 4)
{
    operacion = "Division";
    if (numero2 == 0)
    {
        Console.WriteLine("No se puede dividir por 0");
        goto segundo_numero;
    } else
    {
        resultado = numero1 / numero2;
    }
}

informacion:
Console.WriteLine("==============================================");
Console.WriteLine("Información de la operación");
Console.WriteLine("Operacion Seleccionada : " + operacion);
Console.WriteLine("Primer Numero : " + numero1);
Console.WriteLine("Segundo Numero : " + numero2);
Console.WriteLine("Resultado : " + resultado);
Console.WriteLine("==============================================");
Console.WriteLine();
Console.WriteLine("Presione cualquier tecla para continuar");
Console.ReadKey();
Console.Clear();
goto menu_inicio;