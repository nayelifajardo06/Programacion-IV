using AppPresupuestoRepuestos.GUI;
using AppPresupuestoRepuestos.Mazda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPresupuestoRepuestos
{
    public class MarcaMazda : IRepuestos
    {
        public FiltroAire createFiltroAire(string texto)
        {
            return new MazdaFiltro(texto);
        }

        public DiscoFreno createDiscoFreno(string texto)
        {
            return new MazdaDisco(texto);
        }

        public CajaCambios createCajaCambios(string texto)
        {
            return new MazdaCaja(texto);
        }
    }
}
