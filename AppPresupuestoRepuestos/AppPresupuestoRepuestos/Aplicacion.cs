using AppPresupuestoRepuestos.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPresupuestoRepuestos
{
    public class Aplicacion
    {
        //ATRIBUTOS
        IRepuestos sistema;
        List<IGUIObjects> listaGUI;
        public Aplicacion(IRepuestos sistema)
        {
            this.sistema = sistema;
            listaGUI = new List<IGUIObjects>();
        }

        public void CreateREPUESTOS()
        {
            FiltroAire filtro = sistema.createFiltroAire("EL PRECIO ES DE:");
            DiscoFreno disco = sistema.createDiscoFreno("EL PRECIO ES DE:");
            CajaCambios caja = sistema.createCajaCambios("EL PRECIO ES DE:");

            listaGUI.Add(filtro);
            listaGUI.Add(disco);
            listaGUI.Add(caja);
        }

        public void Presupuesto()
        {
            string screen = "";
            foreach (var objeto in listaGUI)
            {
                screen += objeto.Presupuesto() + "\n";
            }
            Console.WriteLine(screen);
        }
    }
}
