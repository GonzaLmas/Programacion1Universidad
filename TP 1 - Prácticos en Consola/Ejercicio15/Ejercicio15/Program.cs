using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Informar cuantos días faltan para el 25/12/2023

            DateTime fechaAct = DateTime.Now;
            DateTime navidad = new DateTime(2023, 12, 25);
            TimeSpan diasRest = navidad.Subtract(fechaAct);

            Console.WriteLine("Estos son los días que faltan para navidad del año 2023: " + diasRest.TotalDays);
            Console.ReadKey();
        }
    }
}
