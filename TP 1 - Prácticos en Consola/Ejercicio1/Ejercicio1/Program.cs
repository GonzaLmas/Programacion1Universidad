using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados dos valores ingresados por teclado mostrar la suma de ambos.
            int n1 = 0;
            int n2 = 0;

            Console.WriteLine("Ingrese un nro por favor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro nro por favor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma es: {0}", n1 + n2);
            Console.ReadLine();
        }
    }
}
