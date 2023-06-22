using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar la fecha y hora actual.

            DateTime fecha;

            fecha = DateTime.Now;

            Console.WriteLine("La fecha del día de hoy es: " + fecha);
            Console.ReadKey();
        }
    }
}
