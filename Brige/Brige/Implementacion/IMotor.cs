using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brige.Implementacion
{
    public interface IMotor
    {
        //void no devuelve nada
        public void InyectarCombustible(double cantidad);
        public void ConsumirConbustible();
    }
}
