using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Crear un sistema simple para gestionar una lista de estudiantes, donde se pueda agregar, eliminar y mostrar información sobre ellos. El sistema debe utilizar conceptos de programación orientada a objetos como encapsulamiento y herencia.

Requisitos
Clase Base: Persona

Propiedades:
Nombre (string)
Edad (int)
Métodos:
MostrarInfo(): Muestra la información de la persona.
Clase Derivada: Estudiante

Hereda de Persona.
Propiedades adicionales:
Matricula (string)
Calificaciones (List<double>)
Métodos:
AgregarCalificacion(double calificacion): Agrega una calificación a la lista.
PromedioCalificaciones(): Devuelve el promedio de las calificaciones.
Sobrescribir el método MostrarInfo() para incluir la matrícula y el promedio de calificaciones.
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante David = new Estudiante("David" , 22 , "A22I");
            Estudiante Luis = new Estudiante("Luis", 32, "Xd13");
            Estudiante Jose = new Estudiante("Jose", 27, "ERT12");
            
            David.AgregarCalificacion(6.66);
            David.AgregarCalificacion(7.78);
            David.AgregarCalificacion(9.99);


            Luis.AgregarCalificacion(7.7);
            Luis.AgregarCalificacion(3.66);
            Luis.AgregarCalificacion(5.55);


            Jose.AgregarCalificacion(5);
            Jose.AgregarCalificacion(3.33);
            Jose.AgregarCalificacion(6.66);
                
            GestorEstudiantes GestorX = new GestorEstudiantes();

            GestorX.AgregarEstudiante(David);
            GestorX.AgregarEstudiante(Luis);
            GestorX.AgregarEstudiante(Jose);

            GestorX.EvaluarPromedio();
        }
    }
}
