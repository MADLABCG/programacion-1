// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejecucion No Lineal");


int numero1 = 2;
int numero_random = new Random().Next(1, 10);


if(numero1 == numero_random)
{
    Console.WriteLine("Los numeros son iguales " + "numero1= " + numero1 + "numero_random= " + numero_random);
}
else
{
    Console.WriteLine("Los numeros son diferentes " + "numero1= " + numero1 + "numero_random= " + numero_random);
}
