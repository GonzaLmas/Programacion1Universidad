using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados los lados de un triangulo calcular el perímetro.

            int n1, n2, n3;
            int perimetro = 0;

            Console.WriteLine("Ingrese un lado del triángulo: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro lado del triángulo: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el último lado del triángulo: ");
            n3 = int.Parse(Console.ReadLine());

            perimetro = n1 + n2 + n3;

            Console.WriteLine("El perímetro del triángulo es: " + perimetro);

            Console.ReadKey();
        }
    }
}
