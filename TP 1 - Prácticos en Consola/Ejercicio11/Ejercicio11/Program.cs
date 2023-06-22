using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dada una frase informar la cantidad de caracteres que tiene.

            string frase;
            int carac = 0;

            Console.WriteLine("Ingrese una frase: ");
            frase = Console.ReadLine();

            carac = frase.Length;

            Console.WriteLine("La frase tiene {0} caracteres", carac);
            Console.ReadKey();
        }
    }
}
