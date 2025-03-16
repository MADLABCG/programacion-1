Console.WriteLine("Calculadora para Sumar 2 Numeros");

int num1;
int num2;

primer_numero:
try
{
    Console.WriteLine("Ingrese el primer numero: ");
    num1 = Convert.ToInt32(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Esto no es numero ");
    goto primer_numero;
}

segundo_numero:
try
{
    Console.WriteLine("Ingrese el segundo numero: ");
    num2 = Convert.ToInt32(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Esto no es numero ");
    goto segundo_numero;
}

int resultado = num1 + num2;
Console.WriteLine("El resultado de la suma es: " + resultado);
Console.ReadKey();

