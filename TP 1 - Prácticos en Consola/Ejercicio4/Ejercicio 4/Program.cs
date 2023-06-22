using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados los datos necesarios de un Cuadrado calcular la superficie.

            int lado, superficie;

            Console.WriteLine("Ingrese el lado del cuadrado: ");
            lado = int.Parse(Console.ReadLine());

            superficie = lado * lado;

            Console.WriteLine("La superficie del cuadrado es: " + superficie);
            Console.ReadKey();
        }
    }
}
