using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados los datos necesarios de un Rectángulo calcular la superficie.

            int ancho, largo, superficie;

            Console.WriteLine("Ingrese el ancho del cuadrado: ");
            ancho = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el largo del cuadrado: ");
            largo = int.Parse(Console.ReadLine());

            superficie = ancho * largo;

            Console.WriteLine("La superficie del cuadrado es: " + superficie);
            Console.ReadKey();
        }
    }
}
