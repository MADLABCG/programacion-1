using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportacion
{
    public class Vehiculo
    {
        private string? motor;
        private int? goma;
        private int? puerta;
        private int? pasajero;
        private bool? baul;
        private string? combustible;

        public Vehiculo(string? motor, int? goma, 
            int? puerta, int? pasajero, 
            bool? baul, string? combustible)
        {
            this.motor = motor;
            this.goma = goma;
            this.puerta = puerta;
            this.pasajero = pasajero;
            this.baul = baul;
            this.combustible = combustible;
        }

        public string? Motor { 
            get {  return motor; } 
            set {  motor = value; } 
        }

        public int? Gomas { 
            get {  return goma; } 
            set {  goma = value; } 
        }

        public int? Puertas { 
            get {  return puerta; } 
            set {  puerta = value; }
        }

        public int? Pasajeros { 
            get {  return pasajero; } 
            set {  pasajero = value; } 
        }

        public bool? Baul { 
            get { return baul; } 
            set {  baul = value; }
        }

        public string? Combustible { 
            get { return combustible; } 
            set { combustible = value; } 
        }

        public override string? ToString()
        {
            return "Motor: "+ Motor + "\n" 
                + "Puertas: " + Puertas + "\n" 
                + "Gomas: " + Gomas + "\n" 
                + "Tiene Baul: " + Baul + "\n" 
                + "Pasajeros: " + Pasajeros + "\n" 
                + "Tipo Combustible: " + Combustible + "\n";
        }
    }
}
