using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class IndiceFueraDelRangoException : Exception
    {
        public IndiceFueraDelRangoException()
        {
        }

        public IndiceFueraDelRangoException(string message) : base(message)
        {
        }

        public IndiceFueraDelRangoException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
