using System;
namespace animales
{
	public class Perro : Animal
    {

        string? nombre;
        string? raza;

        public Perro(string? familia, int? pata, int? edad,
            string? color, string? nombre, string? raza)
            : base(familia, pata, edad, color)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public string? Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string? Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\n"
                + "Raza: " + Raza + "\n"
                + base.ToString();
        }
    }
}

