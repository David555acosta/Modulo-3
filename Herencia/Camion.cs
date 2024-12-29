using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Camion: Vehiculo 
    {
        public int CargaMaxima { get; set; }

        public string Color { get; set; }
    }
}
