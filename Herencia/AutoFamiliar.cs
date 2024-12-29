using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class AutoFamiliar: Auto   
    {
        public int CantidadDePersonas { get; set; }


        public virtual string MostrarDetalles()
        {
            return $"Marca: {Marca}. Color {Color},  Cantidad de Pueras : {Puertas}, Cantidad de Personas : {CantidadDePersonas}";
        }
    }
}
