using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brige.Implementacion
{
    public class Gasolina : IMotor
    {
        public void InyectarCombustible(double cantidad)
        {
            Console.WriteLine("Inyectando " + cantidad + " ml. de Diesel");
        }
        public void ConsumirConbustible()
        {
            RealizarAceleracion();
        }

        private void RealizarAceleracion()
        {
            Console.WriteLine("Se realizo con exito la aceleracion ");
        }
    }
}
