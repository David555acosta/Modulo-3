using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class CamionetaFamiliar : Camioneta
    {
        public int CantidadDePersonas { get; set; }

        public string Motor { get; set; }


        public override string MostrarDetalles()
        {
            return $"Marca: {Marca}. Color {Color},  cantidad Asientos : {cantidadAsientos} , cantidad de personas {CantidadDePersonas} " +
                $" Motor : {Motor}";
        }
    }

}
