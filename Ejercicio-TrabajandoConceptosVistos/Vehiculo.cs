using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio_TrabajandoConceptosVistos
{
    internal class Vehiculo
    {
        public string Marca { get; set; } //Lectura y escritura.

        public string Modelo {  get; set; }    //Lectura y escritura.

       public int  Año { get; set; }   //Lectura y escritura.



        //Constructor que reciba Marca , Modelo  y año.

        public Vehiculo (string unaMarca , string unModelo , int unAño)
        {
            this.Marca = unaMarca; 
            this.Modelo = unModelo;
            this.Año = unAño;
        }



        //Metodo para mostrar informacion - Para sobreCargargalo usamos el Virtua-Override.

        public virtual string MostrarInfo ()
        {
            return $"Marca: {Marca} , Modelo: {Modelo} , Año: {Año}";  
        }
    }
}
