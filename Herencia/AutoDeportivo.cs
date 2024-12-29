using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class AutoDeportivo: Auto
    {
        public int VelocidadMaxima { get; set; } 

        public int Cilindrada { get; set; }


        public override string MostrarDetalles()
        {
            return $"Marca: {Marca}. Color {Color},  Cantidad de Pueras : {Puertas} , velocidad Maxima: {VelocidadMaxima} ,  Cilindrada {Cilindrada}";
        }

    }
}
