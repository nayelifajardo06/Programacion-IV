using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasDiagrama
{
    public class FiguraCirculo : Figura
    {
        public override IGrafico createFigura()
        {
            Console.WriteLine("CREANDO Figura Circulo");

            return new Circulo();
        }
    }
}
