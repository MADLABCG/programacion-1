using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasControl2
{
    internal class Gallina
    {
        public string Color { get; set; }
        public string Sexo { get; set; }

        public Gallina(string color, string sexo)
        {
            Color = color;
            Sexo = sexo;
        }
    }
}
