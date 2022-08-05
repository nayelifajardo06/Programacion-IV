using Brige.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brige.Abstraction
{
    public class Senda : Vehiculo
    {
        //ATRIBUTO PROPIO
        private int CapacidadMaletero;

        public Senda(IMotor motor, int capacidadMaletero) : base(motor)
        {
            this.CapacidadMaletero = capacidadMaletero;
        }

        //Implementacion del metodo abstracto  
        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("Vehiculo de tipo Senda cuenta con una capacidad de maletero " + CapacidadMaletero + " maletas.");
        }
    }
}
