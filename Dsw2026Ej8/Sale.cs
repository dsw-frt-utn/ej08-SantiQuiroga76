using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Sale
    {
        public decimal ImporteBase { get; set; }
        public virtual decimal CalculateTotal()
        {
            return ImporteBase;
        }
    }
}
