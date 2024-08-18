using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasControl3
{
    internal class Televisor
    {
        public string Marca { get; set; }
        public string Size { get; set; }

        public Televisor(string marca, string size)
        {
            Marca = marca;
            Size = size;
        }
    }
}
