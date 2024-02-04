using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vida
{
    public class Humano
    {
        private string? nombres;
        private string? apellidos;
        private string? genero;
        private int? edad;
        private string? fecha_nacimiento;
        private string? color_cabello;
        private string? color_ojos;
        private int? estatura;

        public Humano(string? nombres, string? apellidos, 
            string? genero, int? edad, 
            string? fecha_nacimiento, string? color_cabello,
            string? color_ojos, int estatura)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.genero = genero;
            this.edad = edad;
            this.fecha_nacimiento = fecha_nacimiento;
            this.color_cabello = color_cabello;
            this.color_ojos = color_ojos;
            this.estatura = estatura;
        }

        public string? Nombres { 
            get {  return nombres; } 
            set {  nombres = value; } 
        }

        public string? Apellidos { 
            get {  return apellidos; } 
            set {  apellidos = value; } 
        }

        public string? Genero { 
            get {  return genero; } 
            set {  genero = value; }
        }

        public int? Edad { 
            get {  return edad; } 
            set {  edad = value; } 
        }

        public string? FechaNacimiento { 
            get { return fecha_nacimiento; } 
            set {  fecha_nacimiento = value; }
        }

        public string? ColorCabello { 
            get { return color_cabello; } 
            set { color_cabello = value; } 
        }

        public string? ColorOjos
        {
            get { return color_ojos; }
            set { color_ojos = value; }
        }

        public int? Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }

        public override string? ToString()
        {
            return "Nombres: "+ Nombres + "\n" 
                + "Apellidos: " + Apellidos + "\n" 
                + "Genero: " + Genero + "\n" 
                + "Edad: " + Edad + "\n" 
                + "Fecha Nacimiento: " + FechaNacimiento + "\n" 
                + "Color Cabello: " + ColorCabello + "\n"
                + "Color Ojos: " + ColorOjos + "\n"
                + "Estatura: " + Estatura;
        }
    }
}
