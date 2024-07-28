using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasControl2
{
    internal class Televisor
    {
        public string Marca { get; set; }
        public string Pulgada { get; set; }

        public Televisor(string marca, string pulgada)
        {
            Marca = marca;
            Pulgada = pulgada;
        }
    }
}
