using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class CamionetaUtilitaria: Camioneta
    {
        public int CapacidadCarga { get; set; }


        public override string MostrarDetalles()
        {
            return $"Marca: {Marca}. Color {Color},  cantidad Asientos : {cantidadAsientos} , Capacidad de carga {CapacidadCarga} ";
        }   
    }

}
