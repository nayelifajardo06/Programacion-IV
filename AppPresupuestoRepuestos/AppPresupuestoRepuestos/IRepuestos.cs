using AppPresupuestoRepuestos.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPresupuestoRepuestos
{
    public interface IRepuestos
    {
        public FiltroAire createFiltroAire(string texto);
        public DiscoFreno createDiscoFreno(string texto);
        public CajaCambios createCajaCambios(string texto);
    }
}
