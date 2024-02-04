// See https://aka.ms/new-console-template for more information

using p1_ejemplos;


Items item1 = new Items("Sombrero Azul", "Sombrero Alto Color Azul", 100, 2300.32, true);

Items item2 = new Items("Sombrero Rosado", "Sombrero Alto Color Rosado", 90, 2500.32, true);

Items item3 = new Items("Gorra Blanca", "Gorra SnapBack Blanca", 540, 1700.98, true);

Items item4 = new Items("Gorra Yankee", "Gorra SnapBack Yankee", 1, 2800, false);

item1.Nombre = "Cafetera Gris";

Console.WriteLine(item1.ToString());
Console.WriteLine(item2.ToString());
Console.WriteLine(item3.ToString());
Console.WriteLine(item4.ToString());