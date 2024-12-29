using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio_TrabajandoConceptosVistos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motor MotorAutoDavid = new Motor("Toyota" , "500" , "300MPS"); //Composicion de la clase por asociacion.
            Coche CocheDavid = new Coche("Ford", "Ranger" , 2020 , 4  , MotorAutoDavid);
            Console.WriteLine(CocheDavid.MostrarInfo());
            Console.WriteLine(CocheDavid.CalcularImpuesto());

            Motor MotorMoto = new Motor("Honda", "300", "250MPS");
            Motocicleta MotoDavid = new Motocicleta("Gilera", "Ninja", 2010, 500, MotorMoto); //Composicion de la clase por asociacion.
            Console.WriteLine(MotoDavid.MostrarInfo());
            Console.WriteLine(MotoDavid.CalcularImpuesto());
        }
    }
}
