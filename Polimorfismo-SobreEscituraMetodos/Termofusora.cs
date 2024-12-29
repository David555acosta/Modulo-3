﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_SobreEscituraMetodos
{
    internal class Termofusora: Plomeria
    {
        public Termofusora(string unaMarca)
        {
            this.marca = unaMarca;
        }

        public override string Marca()
        {
            return $"Su Marca es: {marca}";
        }

        public override string MostrarDetalles()
        {
            return $"Su Termofusora , {Utilidad()}, Marca: {Marca()}";
        }
    }
}
