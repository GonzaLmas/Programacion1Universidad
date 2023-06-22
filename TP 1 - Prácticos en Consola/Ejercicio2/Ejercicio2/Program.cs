using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar  una aplicación de consola que tomando 2 números
            //informe cuantos números hay entre los dos.

            int n1 = 0;
            int n2 = 0;

            Console.WriteLine("Ingrese un numero por favor: ");
            n1 = int.Parse(Console.ReadLine());
         
            Console.WriteLine("Ingrese otro numero por favor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(n2 - n1);
            Console.ReadLine();
        }
    }
}
