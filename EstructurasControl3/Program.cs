// See https://aka.ms/new-console-template for more information
using EstructurasControl3;

Console.WriteLine("Estructuras de Control");

string[] marcas = { "Sony", "Samsung", "LG", "Panasonic", "Toshiba" };
string[] sizes = { "32", "46", "55", "65", "75" };

List<Televisor> televisores = new List<Televisor>();

Random random = new Random();

for (int i = 0; i < 200; i++)
{
    int marcaIndex = random.Next(0, marcas.Length);
    int sizeIndex = random.Next(0, sizes.Length);

    Televisor televisor = new Televisor(marcas[marcaIndex], sizes[sizeIndex]);
    televisores.Add(televisor);
}

int samsung = 0;
int sony = 0;
int lg = 0;
int panasonic = 0;
int toshiba = 0;
int size_32 = 0;
int size_46 = 0;
int size_55 = 0;
int size_65 = 0;
int size_75 = 0;

foreach (Televisor televisor in televisores)
{
    if (televisor.Marca == "Sony")
    {
        sony = sony + 1;
    }
    if (televisor.Marca == "Samsung")
    {
        samsung = samsung + 1;
    }
    if (televisor.Marca == "LG")
    {
        lg = lg + 1;
    }
    if (televisor.Marca == "Panasonic")
    {
        panasonic = panasonic + 1;
    }
    if (televisor.Marca == "Toshiba")
    {
        toshiba = toshiba + 1;
    }
    if (televisor.Size == "32")
    {
        size_32 = size_32 + 1;
    }
    if (televisor.Size == "46")
    {
        size_46 = size_46 + 1;
    }
    if (televisor.Size == "55")
    {
        size_55 = size_55 + 1;
    }
    if (televisor.Size == "65")
    {
        size_65 = size_65 + 1;
    }
    if (televisor.Size == "75")
    {
        size_75 = size_75 + 1;
    }
}

Console.WriteLine($"Sony: {sony}");
Console.WriteLine($"Samsung: {samsung}");
Console.WriteLine($"LG: {lg}");
Console.WriteLine($"Panasonic: {panasonic}");
Console.WriteLine($"Toshiba: {toshiba}");
Console.WriteLine($"32 Pulgadas: {size_32}");
Console.WriteLine($"46 Pulgadas: {size_46}");
Console.WriteLine($"55 Pulgadas: {size_55}");
Console.WriteLine($"65 Pulgadas: {size_65}");
Console.WriteLine($"75 Pulgadas: {size_75}");
Console.WriteLine($"Total: {televisores.Count}");
