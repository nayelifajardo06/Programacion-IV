using Brige.Abstraction;
using Brige.Implementacion;
using System;

namespace Bringe
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            IMotor motorDiesel = new Diesel();
            Vehiculo senda = new Senda(motorDiesel, 4);
            
            motorDiesel.InyectarCombustible(2.4);
            motorDiesel.ConsumirConbustible();
        }

        
    }
}
    

