using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportacion
{
    public class Carro : Vehiculo
    {

        private string? color;
        private string? marca;
        private int? precio;

        public Carro(string? motor, int? goma, int? puerta, 
            int? pasajero, bool? baul, 
            string? combustible, string? color, 
            string? marca, int? precio) : 
            base(motor, goma, puerta, pasajero, baul, combustible)
        {
            this.color = color;
            this.marca = marca;
            this.precio = precio;
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

        public override string? ToString()
        {
            return "Color: " + Color + "\n" 
                + "Marca: " + Marca + "\n" 
                + "Precio: "+ Precio + "\n" 
                + base.ToString();
        }
    }
}
