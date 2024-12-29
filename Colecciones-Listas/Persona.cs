using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Requisitos
Clase Base: Persona

Propiedades:
Nombre (string)
Edad (int)
Métodos:
MostrarInfo(): Muestra la información de la persona.
*/

namespace Colecciones_Listas
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set;}

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
        }
 
    }
}
