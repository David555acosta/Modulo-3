using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_TrabajandoConceptosVistos
{
    internal class Chasis
    {
        public string nroChasisnroChasis { get; set; } //Lectura y escritura pero solo desde la clase chasis

        public Chasis()
        {
            nroChasisnroChasis = "A222i"; //Asigno los valores de forma fija porque sera una asociacion por agregacion
                                          //No se puede modificar el chasis ya que es fijo para cada vehiculo.
        }
    }
}
