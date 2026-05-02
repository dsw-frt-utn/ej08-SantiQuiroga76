using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copyValue = originalValue;
            copyValue = copyValue + 10;

            Product copyProduct = product;
            copyProduct.ModificarDescripcion("Producto generico");

            return $"{originalValue} - {copyValue} - {product.GetDescription()}";
        }
    }
}
