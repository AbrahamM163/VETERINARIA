using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETERINARIA
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Edad { get; set; }

        public double Peso { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - {Tipo} - {Edad} años";
        }

    }
}
