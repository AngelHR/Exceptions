using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //fuerdel rango,listano encontrada,cadenanovalida
            List<Object> l = new List<Object>();
            try
            {
                Console.WriteLine($"1.-{l[92]}");
            }catch(IndiceFueraDelRangoException e)
            {
                e.ToString();
            }
            catch(CadenaNoValidaException e1)
            {
                e1.ToString();
            }
            catch (ListaEmpleadaNoEncontradaException e2)
            {
                e2.ToString();
            }
        }
    }
}
