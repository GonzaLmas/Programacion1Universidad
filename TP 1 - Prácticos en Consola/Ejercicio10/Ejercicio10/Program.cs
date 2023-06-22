using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dada una frase cualquiera llamada x, mostrar como resultado una frase formada
            //por la segunda mitad de x más la primer mitad de x. (usar el método substring).

            string cadena = "Hola Mundo";

            string primeraM, segundaM, resultado;

            primeraM = cadena.Substring(0, 4);
            segundaM = cadena.Substring(5, 5);

            resultado = primeraM + segundaM;

            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadKey();
        }
    }
}
