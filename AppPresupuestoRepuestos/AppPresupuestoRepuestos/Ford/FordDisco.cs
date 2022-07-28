using AppPresupuestoRepuestos.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPresupuestoRepuestos.Ford
{
    public class FordDisco : DiscoFreno
    {
        string text;
        public FordDisco(string text)
        {
            this.text = text;
        }
        public override string Presupuesto()
        {
            Console.WriteLine("EL PRECIO ES:");
            return text;
        }
    }
}
