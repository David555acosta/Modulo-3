using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class CamionTransporte : Camion
    {
        public int CantPasajeros { get; set; }
    




    public override string MostrarDetalles()
        {
            return $"Marca: {Marca}. Color {Color},  Carga maxima : {CargaMaxima} , cantidad pasajeros: {CantPasajeros}";
        }
    }
}
  
