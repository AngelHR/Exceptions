using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class ListaEmpleadaNoEncontradaException:ArgumentOutOfRangeException
    {
        public ListaEmpleadaNoEncontradaException()
        {
        }

        public ListaEmpleadaNoEncontradaException(string message):base(message)
        {
        }

        public ListaEmpleadaNoEncontradaException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
