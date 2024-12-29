using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*
 Clase: GestorEstudiantes

Propiedad:
Estudiantes (List<Estudiante>)
Métodos:
AgregarEstudiante(Estudiante estudiante): Agrega un estudiante a la lista.
EliminarEstudiante(string matricula): Elimina un estudiante de la lista por matrícula.
MostrarEstudiantes(): Muestra la información de todos los estudiantes utilizando foreach.
EvaluarEstudiantes(): Evalúa si el promedio de calificaciones de cada estudiante es mayor o igual a 60 y muestra un mensaje correspondiente.
Ejemplo de Uso
Crear instancias de Estudiante.
Agregar calificaciones.
Utilizar el GestorEstudiantes para gestionar la lista de estudiantes.
Mostrar la información de todos los estudiantes y sus evaluaciones.
Consideraciones
Utiliza encapsulamiento para proteger las propiedades de las clases.
Implementa la lógica de evaluación de condiciones en el método EvaluarEstudiantes() de forma abstracta, permitiendo la reutilización del código.
*/


namespace Colecciones_Listas
{
    internal class GestorEstudiantes
    {
        List<Estudiante> listaEstudiantes = new List<Estudiante>();


        //Metodo AgregarEstudiante
        public void AgregarEstudiante(Estudiante estudiante)
        {
            listaEstudiantes.Add(estudiante);
        }


        //Metodo para eliminar estudiante con una Matricula Especifica

        public void EliminarEstudiante(string unaMatricula)
        {
            if (Elestudiante_EstaEnLista(unaMatricula))
            {
                listaEstudiantes.RemoveAll(est => est.Matricula == unaMatricula);

            }
            else
            {
                Console.WriteLine("No existe ese estudiante");
            }
        }

        //Metodo para buscar al estudiante con la matricula especificada.
        public bool Elestudiante_EstaEnLista(string unaMatriculaX)
        {
            foreach (var est in listaEstudiantes)
            {
                if (est.Matricula == unaMatriculaX)
                {
                    return true;
                }

            }

            return false;
        }


        //Metodo para mostrar a todos los estudiantes de la lista de estudiantes.

        public void MostrarEstudiantes ()
        {
            foreach (Estudiante est in listaEstudiantes)
            {
                Console.WriteLine(est.Matricula); 
            }
        }


        //Metododo para evaluar el promedio de cada estudiante de la lista de estudiantes


        public void EvaluarPromedio ()
        {
            foreach (Estudiante estudiante in listaEstudiantes)
            {
                if (elEstudiante_TieneBuenPromedio(estudiante))
                {
                    Console.WriteLine($"El alumno {estudiante.Nombre} esta aprobado");

                } else 
                {
                    Console.WriteLine($"El alumno {estudiante.Nombre} esta desaprobado");
                }
            }
        }

        //Subdivicion de tareas y abstraer el codigo para evaluar si el promedio de nota de un estudiante resulta aprobado.
       public bool elEstudiante_TieneBuenPromedio (Estudiante estudiante)
        {
            return estudiante.PromedioCalificaciones() > 6;
        }
    } 

}

