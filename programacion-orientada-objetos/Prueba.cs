internal class Prueba
{
    private static void Main(string[] args)
    {
        vida.Humano humano1 = new("Juan Jose", "Perez Garcia", "Masculino", 24, "12 Agosto 1999", "Marron", "Azul", 6);

        

        Console.WriteLine("Humano 1:");
        Console.WriteLine(humano1.ToString());
        
    }
}