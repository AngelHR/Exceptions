using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class CadenaNoValidaException : Exception
    {
        public CadenaNoValidaException()
        {
        }

        public CadenaNoValidaException(string message) : base(message)
        {
        }

        public CadenaNoValidaException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
