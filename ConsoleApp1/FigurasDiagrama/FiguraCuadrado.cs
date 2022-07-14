using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasDiagrama
{
    public class FiguraCuadrado : Figura
    {
        public override IGrafico createFigura()
        {
            Console.WriteLine("CREANDO Figura Cuadrado");

            return new Cuadrado();
        }
    }
}
