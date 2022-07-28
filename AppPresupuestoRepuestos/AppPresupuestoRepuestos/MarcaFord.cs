using AppPresupuestoRepuestos.Ford;
using AppPresupuestoRepuestos.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPresupuestoRepuestos
{
    public class MarcaFord : IRepuestos
    {
        public FiltroAire createFiltroAire(string texto)
        {
            return new FordFiltro(texto);
        }

        public DiscoFreno createDiscoFreno(string texto)
        {
            return new FordDisco(texto);
        }

        public CajaCambios createCajaCambios(string texto)
        {
            return new FordCaja(texto);
        }
    }
}
