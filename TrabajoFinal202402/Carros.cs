namespace TrabajoFinal202402
{
    internal class Carros
    {
        string marca;
        string modelo;
        string color;

        public Carros(string marca, string modelo, string color)
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
            Console.WriteLine("Carro: Marca " + marca + ", Modelo " + modelo + ", Color " + color);
        }
    }
}
