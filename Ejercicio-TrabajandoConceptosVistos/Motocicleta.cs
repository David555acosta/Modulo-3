using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_TrabajandoConceptosVistos
{
    internal class Motocicleta : Vehiculo
    {
        public int Cilindrada;


        //ASOCIACION por composicion mediante lectura y escritura.
        public Motor MotorMoto {  get; set; }

        //Constructor 
        // Constructor que recibe un Motor
        public Motocicleta(string unaMarca, string unModelo, int unAño, int unaCilindrada, Motor motor)
            : base(unaMarca, unModelo, unAño)
        {
            this.Cilindrada = unaCilindrada;
            this.MotorMoto = motor; // Asigna el motor recibido
        }

        //Sobre escribir el metodo mostrar info para que se adapte a las propiedades de las clase.
        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()}, Cilindrada : {Cilindrada},  Motor :{MotorMoto.Marca}";
        }


        public int CalcularImpuesto()
        {
            DateTime fechaActual = DateTime.Now; // Usa la fecha actual
            int añoVehiculo = this.Año; // Obtiene el año del vehículo desde la propiedad base
            int antiguedadVehiculo = fechaActual.Year - añoVehiculo; // Calcula la antigüedad

            int impuesto = 0;

            if (antiguedadVehiculo < 5)
            {
                impuesto = 1; // Menos de 5 años
            }
            else if (antiguedadVehiculo > 10)
            {
                impuesto = 2; // Más de 10 años
            }
            else
            {
                impuesto = 3; // Entre 5 y 10 años
            }

            return impuesto; // Devuelve el impuesto calculado
        }
    }

}

