using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Clase Derivada: Estudiante

Hereda de Persona.
Propiedades adicionales:
Matricula (string)
Calificaciones (List<double>)
Métodos:
AgregarCalificacion(double calificacion): Agrega una calificación a la lista.
PromedioCalificaciones(): Devuelve el promedio de las calificaciones.
Sobrescribir el método MostrarInfo() para incluir la matrícula y el promedio de calificaciones.
*/

namespace Colecciones_Listas
{
    internal class Estudiante : Persona
    {
        public string Matricula { get; set; }

        public List<double> Calificaciones { get; set; } = new List<double>();



        public Estudiante (string nombre , int edad , string matricula)
        {
            this.Matricula = matricula;
            this.Edad = edad;
            this.Nombre = nombre;   
        }

        //Metodo agregar calificiaciones a la lista


        public void AgregarCalificacion (double unaCalificacion)
        {
            Calificaciones.Add (unaCalificacion);
        }



        //Metodo para calcular el promedio de calificaciones de un estudiante.


        public double PromedioCalificaciones ()
        {
            if (Calificaciones.Count == 0) return 0; // Evitar división por cero
            double sumaCalificaciones = 0;

            foreach (var calificacion in Calificaciones)
            {
                sumaCalificaciones += calificacion;
            }


            return sumaCalificaciones / Calificaciones.Count;   
        }



        //Metodo MostrarInfor sobreescrito

        public new void MostrarInfo ()
        {
            Console.WriteLine("Matricula estudiante actual es:" + Matricula);
            Console.WriteLine($"Promedio de calificaciones: {PromedioCalificaciones():F2}");
        }
    }
}
