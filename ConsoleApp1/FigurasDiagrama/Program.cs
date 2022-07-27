using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasDiagrama
{
    public class Program
    {
        public static void Main(String[] args)
        {

            FiguraCuadrado creadorC = new FiguraCuadrado();
            FiguraTriangulo creadorT = new FiguraTriangulo();
            FiguraCirculo creadorCi = new FiguraCirculo();

            Console.WriteLine("------ CREAR LISTA DE FIGURAS ------");

            List<IGrafico> listaFiguras = new List<IGrafico>();

            listaFiguras.Add(creadorC.createFigura());
            listaFiguras.Add(creadorC.createFigura());
            listaFiguras.Add(creadorT.createFigura());
            listaFiguras.Add(creadorT.createFigura());
            listaFiguras.Add(creadorCi.createFigura());
            listaFiguras.Add(creadorCi.createFigura());

            foreach (IGrafico figura in listaFiguras)
            {

                figura.mostrar();

            }

            //CREACION DE LA LISTA CON SOMOOPERATION

            Console.WriteLine("------ LISTA CON DIBUJO ------");
            List<Figura> listaDibujo = new List<Figura>();

            listaDibujo.Add(new FiguraCuadrado());
            listaDibujo.Add(new FiguraCuadrado());
            listaDibujo.Add(new FiguraTriangulo());
            listaDibujo.Add(new FiguraTriangulo());
            listaDibujo.Add(new FiguraCirculo());
            listaDibujo.Add(new FiguraCirculo());

            foreach (Figura dibujos in listaDibujo)
            {

                dibujos.Dibujo();

            }
        }
    }

}