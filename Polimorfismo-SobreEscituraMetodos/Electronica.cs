﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_SobreEscituraMetodos
{
    internal class Electronica : Herramienta
    {
        public override string Utilidad()
        {
            return "Utilidad: Electronica";
        }
    }
}