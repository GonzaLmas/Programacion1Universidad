using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Si la circunferencia de un círculo es pi * Diámetro, desarrollar una aplicación que dada la circunferencia calcule el diámetro.

            double pi = 3.14;
            double circ, diam;

            Console.WriteLine("Ingrese la circunferencia del círculo: ");
            circ = double.Parse(Console.ReadLine());

            diam = circ / pi;

            Console.WriteLine("El diámetro del círculo es: " + diam);
            Console.ReadKey();
        }
    }
}
