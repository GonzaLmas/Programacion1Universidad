using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcualr el factorial de 6.

            int n1 = 1;

            for(int i = 1; i < 7; i++)
                n1 *= i;

            Console.WriteLine("El factorial de 6 es: " + n1);
            Console.ReadKey();
        }
    }
}
