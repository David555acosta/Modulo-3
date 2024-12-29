using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_TrabajandoConceptosVistos
{
    internal class Coche : Vehiculo , IVehiculo
    {
        private int unAño;

        public int NumeroPuertas { get; set; }

        //Composicion
        public Motor MotorAuto { get; set; }

        //Herencia

        public Chasis ChasisAuto { get; }


        //Constructor 
        // Constructor que recibe un Motor
        public Coche(string unaMarca, string unModelo, int unAño, int numeroPuertas, Motor motor)
            : base(unaMarca, unModelo, unAño)
        {
            this.NumeroPuertas = numeroPuertas;
            this.MotorAuto = motor; // Asigna el motor recibido
            ChasisAuto = new Chasis(); // Asegúrate de que Chasis tenga su propia lógica
        }


        //Sobre escribir el metodo mostrar info para que se adapte a las propiedades de las clase.
        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()}, Número de Puertas: {NumeroPuertas} , Motor: {MotorAuto.Marca} , chasis {ChasisAuto.nroChasisnroChasis}";
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

