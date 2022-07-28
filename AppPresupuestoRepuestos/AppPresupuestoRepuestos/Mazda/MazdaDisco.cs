﻿using AppPresupuestoRepuestos.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPresupuestoRepuestos.Mazda
{
    public class MazdaDisco : DiscoFreno
    {
        string text;
        public MazdaDisco(string text)
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
