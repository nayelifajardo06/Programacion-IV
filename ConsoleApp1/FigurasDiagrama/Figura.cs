using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasDiagrama
{
    //PARA CREAR UNA CLASE ABSTRACTA
    public abstract class Figura
    {
        public abstract IGrafico createFigura();

        public void Dibujo()
        {
            Console.WriteLine("HACIENDO ALGO EN Figura");

            IGrafico g = createFigura();
            g.mostrar();

        }
    }
}
