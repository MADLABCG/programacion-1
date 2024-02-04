using System;
namespace vida
{
    public class Dominicano : Humano
    {
        string? cedula;
        bool? juega_pelota;

        public Dominicano(string? cedula, bool? juega_pelota, string? nombres, string? apellidos,
            string? genero, int? edad,
            string? fecha_nacimiento, string? color_cabello,
            string? color_ojos, int estatura) 
            : base(nombres, apellidos, genero, edad, fecha_nacimiento, color_cabello, color_ojos, estatura)
        {
            this.cedula = cedula;
            this.juega_pelota = juega_pelota;
            
        }

        public string? Cedula { 
            get {  return cedula; }
            set { cedula = value; }
        }
        public bool? JuegaPelota { 
            get {  return juega_pelota; }
            set { juega_pelota = value; }
        }

        public override string ToString()
        {
            return "Cedula: " + Cedula + "\n"
                + "Juega Pelota: " + JuegaPelota + "\n" 
                + base.ToString();
        }
    }
}

