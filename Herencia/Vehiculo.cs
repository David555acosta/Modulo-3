using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Vehiculo
    {
        public string Marca { get; set; }

        public virtual string MostrarDetalles()
        {
            return "Caracteristicas Auto:";
        }
    }
}
