// See https://aka.ms/new-console-template for more information
using System;
using TrabajoFinal202402;

Console.WriteLine("===========================================================");
Console.WriteLine("Trabajo Final - Ivan Firestone - Matricula 00-00-00-00");
Console.WriteLine("===========================================================");
Console.WriteLine(" ");
string[] marcas_camiones = { "Volvo", "Scania", "Mercedes Benz", "International", "Kenworth" };
string[] modelos_camiones = { "FH16", "R730", "Actros", "Lonestar", "T680" };
string[] colores_camiones = { "Rojo", "Azul", "Blanco", "Verde", "Amarillo" };

string[] marcas_carros = { "Toyota", "Honda", "Ford", "Chevrolet", "Nissan" };
string[] modelos_carros = { "Corolla", "Civic", "Fiesta", "Spark", "Sentra" };
string[] colores_carros = { "Rojo Chino", "Azul Bolita", "Blanco Perla", "Verde Botella", "Amarillo Pollito" };

string[] marcas_motocicletas = { "Yamaha", "Suzuki", "Kawasaki", "Ducati" };
string[] modelos_motocicletas = { "R1", "CBR1000RR", "GSX-R1000", "Ninja ZX-10R", "Panigale V4" };
string[] colores_motocicletas = { "Rojo", "Azul", "Blanco", "Negro", "Gris" };

int volvo = 0;
int scania = 0;
int mercedes = 0;
int international = 0;
int kenworth = 0;

int toyota = 0;
int honda = 0;
int ford = 0;
int chevrolet = 0;
int nissan = 0;

int yamaha = 0;
int suzuki = 0;
int kawasaki = 0;
int ducati = 0;

int cantidad_vehiculos = 3;

Random rand = new Random();
List<Camiones> camiones = new List<Camiones>();
List<Carros> carros = new List<Carros>();
List<Motocicletas> motocicletas = new List<Motocicletas>();

//Creamos los Camiones
for (int i = 0; i < cantidad_vehiculos; i++)
{
    int marcaIndex = rand.Next(0, marcas_camiones.Length);
    int modeloIndex = rand.Next(0, modelos_camiones.Length);
    int colorIndex = rand.Next(0, colores_camiones.Length);
    
    Camiones camion = new Camiones(marcas_camiones[marcaIndex], modelos_camiones[modeloIndex], colores_camiones[colorIndex]);
    camiones.Add(camion);
}

//Creamos los Carros
for (int i = 0; i < cantidad_vehiculos; i++)
{
    int marcaIndex = rand.Next(0, marcas_carros.Length);
    int modeloIndex = rand.Next(0, modelos_carros.Length);
    int colorIndex = rand.Next(0, colores_carros.Length);

    Carros carro = new Carros(marcas_carros[marcaIndex], modelos_carros[modeloIndex], colores_carros[colorIndex]);
    carros.Add(carro);
}

//Creamos las Motocicletas
for (int i = 0; i < cantidad_vehiculos; i++)
{
    int marcaIndex = rand.Next(0, marcas_motocicletas.Length);
    int modeloIndex = rand.Next(0, modelos_motocicletas.Length);
    int colorIndex = rand.Next(0, colores_motocicletas.Length);

    Motocicletas motocicleta = new Motocicletas(marcas_motocicletas[marcaIndex], modelos_motocicletas[modeloIndex], colores_motocicletas[colorIndex]);
    motocicletas.Add(motocicleta);
}

//Mostramos los datos de los Camiones
Console.WriteLine("===========================================================");
Console.WriteLine("Camiones Creados");
foreach (Camiones camion in camiones)
{
    if(camion.Marca == "Volvo")
    {
        volvo = volvo + 1;
    }
    if (camion.Marca == "Scania")
    {
        scania = scania + 1;
    }
    if (camion.Marca == "Mercedes Benz")
    {
        mercedes = mercedes + 1;
    }
    if (camion.Marca == "International")
    {
        international = international + 1;
    }
    if (camion.Marca == "Kenworth")
    {
        kenworth = kenworth + 1;
    }
    camion.MostrarDatos();
}
Console.WriteLine("Cantidad de Camiones por Marca");
Console.WriteLine("Volvo: " + volvo);
Console.WriteLine("Scania: " + scania);
Console.WriteLine("Mercedes Benz: " + mercedes);
Console.WriteLine("International: " + international);
Console.WriteLine("Kenworth: " + kenworth);
Console.WriteLine("===========================================================");
Console.WriteLine(" ");

//Mostramos los datos de los Carros
Console.WriteLine("===========================================================");
Console.WriteLine("Carros Creados");
foreach (Carros carro in carros)
{
    if (carro.Marca == "Toyota")
    {
        toyota = toyota + 1;
    }
    if (carro.Marca == "Honda")
    {
        honda = honda + 1;
    }
    if (carro.Marca == "Ford")
    {
        ford = ford + 1;
    }
    if (carro.Marca == "Chevrolet")
    {
        chevrolet = chevrolet + 1;
    }
    if (carro.Marca == "Nissan")
    {
        nissan = nissan + 1;
    }
    carro.MostrarDatos();
}
Console.WriteLine("Cantidad de Carros por Marca");
Console.WriteLine("Toyota: " + toyota);
Console.WriteLine("Honda: " + honda);
Console.WriteLine("Ford: " + ford);
Console.WriteLine("Chevrolet: " + chevrolet);
Console.WriteLine("Nissan: " + nissan);
Console.WriteLine("===========================================================");
Console.WriteLine(" ");

//Mostramos los datos de las Motocicletas
Console.WriteLine("===========================================================");
Console.WriteLine("Motocicletas Creadas");
foreach (Motocicletas motocicleta in motocicletas)
{
    //"Yamaha", "Suzuki", "Kawasaki", "Ducati"
    if (motocicleta.Marca == "Yamaha")
    {
        yamaha = yamaha + 1;
    }
    if (motocicleta.Marca == "Suzuki")
    {
        suzuki = suzuki + 1;
    }
    if (motocicleta.Marca == "Kawasaki")
    {
        kawasaki = kawasaki + 1;
    }
    if (motocicleta.Marca == "Ducati")
    {
        ducati = ducati + 1;
    }
    
    motocicleta.MostrarDatos();
}
Console.WriteLine("Cantidad de Motocicletas por Marca");
Console.WriteLine("Yamaha: " + yamaha);
Console.WriteLine("Suzuki: " + suzuki);
Console.WriteLine("Kawasaki: " + kawasaki);
Console.WriteLine("Ducati: " + ducati);
Console.WriteLine("===========================================================");
Console.WriteLine(" ");
