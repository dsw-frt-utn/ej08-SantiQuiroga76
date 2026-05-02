using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal partial class ProductHelper
    {
        private string FormateoPrecio(decimal price)
        {
            string precioMod = price.ToString("N2");

            return $"${precioMod}";
        }

        private const string separador = " - ";
    }
}
