using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return ImporteBase * 0.9m;
        }
    }
}
