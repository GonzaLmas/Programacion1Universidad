using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dadas dos frases concatenarlas y mostrar el resultado. 

            string frase1 = "hola";
            string frase2 = " cómo estás?";
            string fraseConcat;
            
            fraseConcat = string.Concat( frase1, frase2);

            Console.WriteLine("La frase concatenada es: " + fraseConcat);
            Console.ReadKey();
        }
    }
}
