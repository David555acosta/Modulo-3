using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_SobreEscituraMetodos
{
    internal class Martillo: Construccion , Interface1
    {

        public Martillo(string unaMarca)
        {
            this.marca = unaMarca;
        }

        public override string Marca()
        {
            return $"Su Marca es: {marca}";
        }

        public override string MostrarDetalles()
        {
            return $"Su martillo , {Utilidad()}, Marca: {Marca()}";
        }

        string Interface1.Tipo()
        {
            return "Uso hogar";
        }
    }
}
