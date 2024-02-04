
namespace transportacion
{
    public class Camion : Vehiculo
    {
        private string? color;
        private string? marca;
        private int? precio;
        private int? tonelaje;
        private int? eje;

        public Camion(string? motor, int? goma, int? puerta, 
            int? pasajero, bool? baul, string? combustible, 
            string? color, string? marca, int? precio, 
            int? tonelaje, int? eje) 
            : base(motor, goma, puerta, pasajero, baul, combustible)
        {
            this.color = color;
            this.marca = marca;
            this.precio = precio;
            this.tonelaje = tonelaje;
            this.eje = eje;
        }

        public string? Color
        {
            get { return color; }
            set { color = value; }
        }

        public string? Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int? Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int? Tonelaje
        {
            get { return tonelaje; }
            set { tonelaje = value; }
        }

        public int? Ejes
        {
            get { return eje; }
            set { eje = value; }
        }

        public override string? ToString()
        {
            return "Color: " + Color + "\n" 
                + "Marca: " + Marca + "\n" 
                + "Precio: " + Precio + "\n" 
                + "Tonelaje: " + Tonelaje+ "\n" 
                + "Ejes: " + Ejes + "\n" 
                + base.ToString();
        }
    }
}
