using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dadas dos fechas calcular la diferencia en días entre una y la otra.

            DateTime fecha1 = new DateTime(2022, 05, 06); 
            DateTime fecha2 = new DateTime(2016, 06, 15);

            //Al usar substract, el objeto que devuelve es un TimeSpan. Este objecto tiene, dias, hs, min, seg y miliseg.
            //Si quiero que me muestre solo los días hago uso del método TotalDays para que me muestre los días unicamente.
            TimeSpan diferencia; 

            diferencia = fecha1.Subtract(fecha2); 

            Console.WriteLine("La diferencia entre las dos fechas es de " + diferencia.TotalDays + " días.");
            Console.ReadKey();
        }
    }
}
