using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_ejemplos
{
    public class Items
    {
        String? nombre;
        String? descripcion;
        int? cantidad;
        double? precio;
        Boolean? isVendible;

        public Items(string? nombre, string? descripcion, int? cantidad, double? precio, bool? isVendible)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
            this.isVendible = isVendible;
        }

        public Items()
        {
            
        }

        public string? Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string? Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int? Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Double? Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Boolean? IsVendible
        {
            get { return isVendible; }
            set { isVendible = value; }
        }

        public Double? Ganancia
        {
            get { return precio * cantidad; }
        }


        public override string? ToString()
        {
            return "Nombre: " + nombre + "\n"
                + "Descripcion: " + descripcion + "\n"
                + "Cantidad Vendida: " + cantidad + "\n"
                + "Precio de Venta: " + precio + "\n"
                + "Puede Ser Vendido: " + isVendible + "\n"
                + "Ganancia de Ventas: " + Ganancia + "\n";
        }
    }
}
