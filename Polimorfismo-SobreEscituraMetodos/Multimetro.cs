using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_SobreEscituraMetodos
{
    internal class Multimetro: Electricidad
    {
        public Multimetro(string unaMarca)
        {
            this.marca = unaMarca;
        }

        public override string Marca()
        {
            return $"Su Marca es: {marca}";
        }

        public override string MostrarDetalles()
        {
            return $"Su Multimetro , {Utilidad()}, Marca: {Marca()}";
        }
    }
}
