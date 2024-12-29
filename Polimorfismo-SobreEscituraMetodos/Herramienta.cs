using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_SobreEscituraMetodos


{
    internal class Herramienta
    {

        public string marca {  get; set; }


        public virtual string Utilidad ()
        {
            return "Estandar";
        }

        public virtual string Marca ()
        {
            return marca;
        }


        public virtual string MostrarDetalles ()
        {
            return $"Utilidad : {Utilidad()} , Marca: {Marca()}";
        }
    }
}
