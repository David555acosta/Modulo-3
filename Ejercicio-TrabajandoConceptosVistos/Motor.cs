using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_TrabajandoConceptosVistos
{
    internal class Motor
    {
        public string Marca {  get; set; } //Lectura escritura
        public string Potencia { get; set; } //Lectura escritura

        public string Velocidad { get; set; } //Lectura escritura


        //Constructor Motor - como vamos a asociarlo mediante composicion - se pueden crear motores para diferentes autos.
        public Motor(string unaMarca , string unaPotencia , string unaVelocidad)
        {
            this.Marca = unaMarca;
            this.Potencia = unaPotencia;
            this.Velocidad = unaVelocidad;   
        }

    }
}
