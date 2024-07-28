// See https://aka.ms/new-console-template for more information
using EstructurasControl2;

Console.WriteLine("Estructuras de Control");

string[] marcas = { "Samsung", "LG", "TCL", "Vizio", "Sony" };
string[] pulgadas = { "32", "55", "65" };


List<Televisor> televisores = new List<Televisor>();


Random random = new Random();


for (int i = 0; i < random.Next(0,1000); i++)
{
    // escogemos un color aleatorio
    string marca = marcas[random.Next(marcas.Length)];
    string pulgada = pulgadas[random.Next(pulgadas.Length)];

    // Creamos un telvisor con la marca aleatoria y la agregamos a la lista
    televisores.Add(new Televisor(marca, pulgada));
}

int samsung = 0;
int lg = 0;
int tcl = 0;
int vizio = 0;
int sony = 0;
int total = 0;
int pulgadas32 = 0;
int pulgadas55 = 0;
int pulgadas65 = 0;

foreach (var tv in televisores)
{
    if(tv.Marca == "Samsung")
    {
        samsung = samsung + 1;  
    }
    if (tv.Marca == "LG")
    {
        lg = lg + 1;
    }
    if (tv.Marca == "TCL")
    {
        tcl = tcl + 1;
    }
    if (tv.Marca == "Vizio")
    {
        vizio = vizio + 1;
    }
    if (tv.Marca == "Sony")
    {
        sony = sony + 1;
    }
    total = total + 1;
    if (tv.Pulgada == "32")
    {
        pulgadas32 = pulgadas32 + 1;
    }
    if (tv.Pulgada == "55")
    {
        pulgadas55 = pulgadas55 + 1;
    }
    if (tv.Pulgada == "65")
    {
        pulgadas65 = pulgadas65 + 1;
    }
    
}

Console.WriteLine("Televisores Samsung: " + samsung);
Console.WriteLine("Televisores LG: " + lg);
Console.WriteLine("Televisores TCL: " + tcl);
Console.WriteLine("Televisores Vizio: " + vizio);
Console.WriteLine("Televisores Sony: " + sony);
Console.WriteLine("Televisores de 32 pulgadas: " + pulgadas32);
Console.WriteLine("Televisores de 55 pulgadas: " + pulgadas55);
Console.WriteLine("Televisores de 65 pulgadas: " + pulgadas65);
Console.WriteLine("Total de Televisores: " + total);
