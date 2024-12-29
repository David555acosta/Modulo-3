using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Camion_de_Carga : Camion
    {
           
        public int CantidadDeacoplados { get; set; } 


        public string Potencia { get; set; }

        public override string MostrarDetalles()
        {
            return $"Marca: {Marca}. Color {Color},  Carga maxima : {CargaMaxima} , cantidad Acomplados {CantidadDeacoplados} , potencia : {Potencia}";
        }
    }
}
