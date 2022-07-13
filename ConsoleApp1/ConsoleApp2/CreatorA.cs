using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama
{
    public class CreatorA : Creator
    {
        public override IProduct createProduct()
        {
            Console.WriteLine("CREANDO Product A");

            return new ProductA();
        }
    }
}
