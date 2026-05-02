using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal totalCalculado;
            if (quantity <= 0)
            {
                totalCalculado = 0;
            }
            else
            {
                totalCalculado = quantity * unitPrice;
            }

            var anonymousProduct = new {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total =  totalCalculado
                };

            return $"{anonymousProduct.Code} - {anonymousProduct.Description} - ${(anonymousProduct.Total).ToString("N2")}";
        }
    }
}
