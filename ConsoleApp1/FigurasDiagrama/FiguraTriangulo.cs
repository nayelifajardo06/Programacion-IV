using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasDiagrama
{
    public class FiguraTriangulo : Figura
    {
        public override IGrafico createFigura()
        {
            Console.WriteLine("CREANDO Figura Triangulo");

            return new Triangulo();
        }
    }
}
