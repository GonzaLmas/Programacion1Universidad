using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Si 1Byte tiene 8 bits, desarrolle una solución programática que permita calcular cuántos bits hay
            //en cualquier combinación de x KBytes. 

            int n1, res;
            int kb = 1;
            int bits = 8000;

            Console.WriteLine("Ingrese la cantidad de kBytes que desea conocer: ");
            n1 = int.Parse(Console.ReadLine());

            res = (n1 * bits) / kb;

            Console.WriteLine("La cantidad de bits que hay en {0}kB es: {1}", n1, res);
            Console.ReadKey();
        }
    }
}
