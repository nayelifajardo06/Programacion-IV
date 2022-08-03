using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brige.Implementacion
{
    public class Diesel : IMotor
    {
        public void ConsumirConbustible(double cantidad)
        {
            Console.WriteLine("Inyectando " + cantidad + " ml. de Diesel");
        }

        public void InyectarCombustible(double cantidad)
        {
            RealizarAceleracion();
        }

        private void RealizarAceleracion()
        {
            Console.WriteLine("Se realizo con exito la aceleracion");
        }
    }
}
