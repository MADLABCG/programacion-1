using System;
namespace animales
{
    public class Animal
    {
        private string? familia;
        private int? pata;
        private int? edad;
        private string? color;

        public Animal(string? familia, int? pata, int? edad, string? color)
        {
            this.familia = familia;
            this.pata = pata;
            this.edad = edad;
            this.color = color;
        }

        public string? Familia { 
            get {  return familia; } 
            set {  familia = value; } 
        }

        public int? Patas
        {
            get { return pata; }
            set { pata = value; }
        }

        public int? Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string? Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string ToString()
        {
            return 
                "Familia: " + Familia + "\n" 
                + "Patas: " + Patas + "\n" 
                + "Edad: " + Edad + "\n" 
                + "Color: " + Color + "\n";
        }

    }
}
