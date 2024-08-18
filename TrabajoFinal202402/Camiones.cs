namespace TrabajoFinal202402
{
    internal class Camiones
    {
        string marca;
        string modelo;
        string color;

        public Camiones(string marca, string modelo, string color)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Camion: Marca " + marca + ", Modelo " + modelo + ", Color " + color);
        }
    }
}
