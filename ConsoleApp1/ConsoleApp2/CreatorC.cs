using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama
{
    public class CreatorC : Creator
    {
        public override IProduct createProduct()
        {
            Console.WriteLine("CREANDO Product C");

            return new ProductC();
        }
    }
}
