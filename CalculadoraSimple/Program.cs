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
Console.WriteLine("Opcion 5: Calculo ITBIS");
Console.WriteLine("Opcion 6: Inverso Calculo ITBIS");
Console.WriteLine("Opcion 7: Porcentaje");
Console.WriteLine("Opcion 8: Salir Sistema");
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


switch(opcion)
{
    case 1:
        opcionSumar();
        goto inicio;
    case 2:
        opcionRestar();
        goto inicio;
    case 3:
        opcionDividir();
        goto inicio;
    case 4:
        opcionMultiplicar();
        goto inicio;
    case 5:
        opcionITBIS();
        goto inicio;
    case 6:
        opcionInversoITBIS();
        goto inicio;
    case 7:
        opcionPorcentaje();
        goto inicio;
    case 8:
        System.Environment.Exit(0);
        break;
    default:
        Console.Clear();
        isError = true;
        goto inicio;
}


void opcionPorcentaje()
{
    double numero1;
    double numero2;

solicitar_numero1:
    Console.WriteLine("Por favor entre el Numero a Calcular");
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
    Console.WriteLine("Por favor entre el Porcentaje a aplicar");
    try
    {
        numero2 = double.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Favor digite un numero");
        goto solicitar_numero2;
    }
    Console.Clear();
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Resultados Porcentaje - Opcion 7");
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Numero a Calcular : " + numero1);
    Console.WriteLine("Porcentaje a Aplicar : " + numero2);
    Console.WriteLine("Resultado : " + calcularPorcentaje(numero1, numero2));
    Console.WriteLine("=======================================================================");
    Console.WriteLine(" ");
}

void opcionInversoITBIS()
{
    double numero1;

solicitar_numero1:
    Console.WriteLine("Por favor entre el Precio con ITBIS Incluido");
    try
    {
        numero1 = double.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Favor digite un numero");
        goto solicitar_numero1;
    }
    Console.Clear();
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Resultados Inverso ITBIS - Opcion 6");
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Precio ITBIS Incluido : " + numero1);
    Console.WriteLine("Precio SIN ITBIS : " + invertirItbis(numero1));
    Console.WriteLine("=======================================================================");
    Console.WriteLine(" ");
}

void opcionITBIS()
{
    double numero1;

solicitar_numero1:
    Console.WriteLine("Por favor entre el Precio a cual Calcular ITBIS");
    try
    {
        numero1 = double.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Favor digite un numero");
        goto solicitar_numero1;
    }
    Console.Clear ();
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Resultados ITBIS - Opcion 5");
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Numero a Calcular: " +  numero1);
    Console.WriteLine("ITBIS : " + calcularItbis(numero1));
    Console.WriteLine("Precio Venta (ITBIS Incluido): " + (sumar(calcularItbis(numero1), numero1)));
    Console.WriteLine("=======================================================================");
    Console.WriteLine(" ");
}

void opcionRestar()
{
    double numero1;
    double numero2;

solicitar_numero1:
    Console.WriteLine("Por favor entre el Minuendo (numero al que se le quita)");
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
    Console.WriteLine("Por favor entre el Sustraendo (nuero que se resta");
    try
    {
        numero2 = double.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Favor digite un numero");
        goto solicitar_numero2;
    }

    Console.Clear();
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Resultados Resta - Opcion 2");
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Minuendo : " + numero1);
    Console.WriteLine("Sustraendo : " + numero2);
    Console.WriteLine("Resultado: " + restar(numero1, numero2));
    Console.WriteLine("=======================================================================");
    Console.WriteLine(" ");
}

void opcionSumar()
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

    Console.Clear();
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Resultados Suma - Opcion 1");
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Numero 1 : " + numero1);
    Console.WriteLine("Numero 2 : " + numero2);
    Console.WriteLine("Resultado: " + sumar(numero1, numero2));
    Console.WriteLine("=======================================================================");
    Console.WriteLine(" ");
}

void opcionDividir()
{
    double numero1;
    double numero2;

solicitar_numero1:
    Console.WriteLine("Por favor entre el Dividendo (numero a dividir)");
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
    Console.WriteLine("Por favor entre el Divisor (numero dividir entre)");
    try
    {
        numero2 = double.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Favor digite un numero");
        goto solicitar_numero2;
    }

    Console.Clear();
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Resultados Division - Opcion 3");
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Dividendo : " + numero1);
    Console.WriteLine("Divisor : " + numero2);
    Console.WriteLine("Resultado: " + dividir(numero1, numero2));
    Console.WriteLine("=======================================================================");
    Console.WriteLine(" ");
}

void opcionMultiplicar()
{
    double numero1;
    double numero2;

solicitar_numero1:
    Console.WriteLine("Por favor entre el Multiplicando (primer numero a multiplicar)");
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
    Console.WriteLine("Por favor entre el Multiplicador (segundo numero a multiplicar)");
    try
    {
        numero2 = double.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Favor digite un numero");
        goto solicitar_numero2;
    }

    Console.Clear();
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Resultados Multiplicacion - Opcion 4");
    Console.WriteLine("=======================================================================");
    Console.WriteLine("Multiplicando : " + numero1);
    Console.WriteLine("Multiplicador : " + numero2);
    Console.WriteLine("Resultado: " + multiplicar(numero1, numero2));
    Console.WriteLine("=======================================================================");
    Console.WriteLine(" ");
}

double sumar(double x, double y)
{
    return x + y;
}

double restar(double minuendo, double sustraendo)
{
    return minuendo - sustraendo;
}

double dividir(double dividendo, double divisor)
{
    return dividendo / divisor;
}

double multiplicar(double x, double y)
{
    return x * y;
}

double calcularItbis(double x)
{
    return (x * (18/100));
}

double invertirItbis(double x)
{
    return (x / 1.18);
}

double calcularPorcentaje(double x, double y)
{
    return (x * (y/100));
}
