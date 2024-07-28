

int rojas = 0;
int rojas_hembras = 0;
int rojas_machos = 0;

int blancas = 0;
int blancas_hembras = 0;
int blancas_machos = 0;

int negras = 0;
int negras_hembras = 0;
int negras_machos = 0;

int hembras = 0;
int machos = 0;

// Colores para las Gallinas
string[] colors = { "Roja", "Blanca", "Negra" };
string[] sexos = { "Hembra", "Macho" };

// Crear una lista que soporte las gallinas 
List<Gallina> gallinas = new List<Gallina>();

// Un generador randon para los colores
Random random = new Random();

// Creamos 100 gallinas con colores aleatorios
for (int i = 0; i < 100; i++)
{
    // escogemos un color aleatorio
    string color = colors[random.Next(colors.Length)];
    string sexo = sexos[random.Next(sexos.Length)];

    // Creamos una gallina con el color aleatorio y la agregamos a la lista
    gallinas.Add(new Gallina(color, sexo));
}

// Iteramos la Lista de Gallinas y mostramos el color de cada gallina
foreach (var gallina in gallinas)
{
    if (gallina.Color == "Roja")
    {
        rojas = rojas + 1;
        if (gallina.Sexo == "Hembra")
        {
            rojas_hembras = rojas_hembras + 1;
        }
        if (gallina.Sexo == "Macho")
        {
            rojas_machos = rojas_machos + 1;
        }
    }
    if (gallina.Color == "Blanca")
    {
        blancas = blancas + 1;
        if (gallina.Sexo == "Hembra")
        {
            blancas_hembras = blancas_hembras + 1;
        }
        if (gallina.Sexo == "Macho")
        {
            blancas_machos = blancas_machos + 1;
        }
    }
    if (gallina.Color == "Negra")
    {
        negras = negras + 1;
        if (gallina.Sexo == "Hembra")
        {
            negras_hembras = negras_hembras + 1;
        }
        if (gallina.Sexo == "Macho")
        {
            negras_machos = negras_machos + 1;
        }
    }
    if (gallina.Sexo == "Hembra")
    {
        hembras = hembras + 1;
    }
    if (gallina.Sexo == "Macho")
    {
        machos = machos + 1;
    }
}

Console.WriteLine("Gallinas Negras: " + negras);
Console.WriteLine("Gallinas Negras Hembras: " + negras_hembras);
Console.WriteLine("Gallinas Negras Machos: " + negras_machos);

Console.WriteLine("Gallinas Blancas: " + blancas);
Console.WriteLine("Gallinas Blancas Hembras: " + blancas_hembras);
Console.WriteLine("Gallinas Blancas Machos: " + blancas_machos);

Console.WriteLine("Gallinas Rojas: " + rojas);
Console.WriteLine("Gallinas Rojas Hembras: " + rojas_hembras);
Console.WriteLine("Gallinas Rojas Machos: " + rojas_machos);


Console.WriteLine("Gallinas Hembras Totales: " + hembras);
Console.WriteLine("Gallinas Machos Totales: " + machos);