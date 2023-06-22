using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    public class Cola
    {
        // Decalaro una variable _inicio para almacenar al primer item de la cola
        public Factura _inicio { get; set; }

        // Agrega al final de la cola un item. Para eso tiene que buscar cual es el final, lo hace preguntando si el siguiente item es null
        public void Encolar(Factura fact)
        {
            if (_inicio == null)
                _inicio = fact;
            else
            {
                Factura aux = BuscarUltimo(_inicio);
                aux.Siguiente = fact;
            }
        }

        // Quita el primer item de la lista asignando al inicio el siguiente item
        public void Desencolar()
        {
            _inicio = _inicio.Siguiente;
        }

        // Función recursiva que busca el último item preguntando si el item siguiente es null
        private Factura BuscarUltimo(Factura fact)
        {
            if (fact.Siguiente == null)
                return fact;
            else
                return BuscarUltimo(fact.Siguiente);
        }

        // Retorna el valor que está en el inicio de la cola
        public Factura Inicio
        {
            get { return _inicio; }
        }

        // Retorna true si la cola está vacía
        public bool Vacia()
        {
            return (_inicio == null);
        }

    }
}
