using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoDeportivo autoDeportivoDavid = new AutoDeportivo();

            autoDeportivoDavid.Marca = "Ferrari";
            autoDeportivoDavid.Puertas = 2;
            autoDeportivoDavid.Color = "Rojo";
            autoDeportivoDavid.Cilindrada = 8;
            autoDeportivoDavid.VelocidadMaxima = 350;


            Console.WriteLine(autoDeportivoDavid.MostrarDetalles());    

        }
    }
}
