namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {      
            Console.WriteLine("==== PRUEBA PROBLEMA 1 =====");
            ProductHelper helper = new ProductHelper();
            String etiqueta = helper.ObtenerEtiquetaProducto(1045, "Teclado mecanico", 5764823m);
            Console.WriteLine(etiqueta);
            Console.WriteLine();
            Console.WriteLine("==== PRUEBA PROBLEMA 2 =====");
            Problema2 test = new Problema2();
            String etiquet = test.CrearResumenVenta(1765, "Parlante Bluetooth", 2, 78656m);
            String etiquet2 = test.CrearResumenVenta(2345, "Parlante PC", -5, 756m);
            Console.WriteLine(etiquet);
            Console.WriteLine(etiquet2);
            Console.WriteLine();
            Console.WriteLine("==== PRUEBA PROBLEMA 3 =====");
            Problema3 prob3 = new Problema3();
            Product product = new Product();
            product.SetDescription("Libro");
            String comparacion = prob3.CompararCopias(25, product);
            Console.WriteLine(comparacion);
            Console.WriteLine();
            Console.WriteLine("==== PRUEBA PROBLEMA 4 =====");
            Problema4 prob4 = new Problema4();
            double promedio = prob4.CalcularPromedio(null, 5, 7);
            double promedio2 = prob4.CalcularPromedio(null, null, null);
            double promedio3 = prob4.CalcularPromedio(2, 5, 17);
            double promedio4 = prob4.CalcularPromedio(-15, null, 27);
            Console.WriteLine(promedio);
            Console.WriteLine(promedio2);
            Console.WriteLine(promedio3);
            Console.WriteLine(promedio4);
            Console.WriteLine();
            Console.WriteLine("==== PRUEBA PROBLEMA 5 =====");
            Problema5 prob5 = new Problema5();
            Sale ventaMinorista = new RetailSale();
            ventaMinorista.ImporteBase = 1500;
            Sale ventaMayorista = new WholesaleSale();
            ventaMayorista.ImporteBase = 1500;
            Sale ventaNormal = new Sale();
            ventaNormal.ImporteBase = 1500;
            decimal resultMinorista = prob5.ObtenerImporteFinal(ventaMinorista);
            Console.WriteLine($"Total s/ desc: ${resultMinorista}");
            decimal resultMayorista = prob5.ObtenerImporteFinal(ventaMayorista);
            Console.WriteLine($"Total c/ 10% desc: ${resultMayorista}");
            decimal resultNormal = prob5.ObtenerImporteFinal(ventaNormal);
            Console.WriteLine($"Total: ${resultNormal}");
            Console.WriteLine();
            Console.WriteLine("==== PRUEBA PROBLEMA 6 =====");
            Problema6 prob6 = new Problema6();
            string code = prob6.NormalizarCodigoProducto("  fkskj 1284 kfjioe   ");
            string code2 = prob6.NormalizarCodigoProducto(" ab 123 x ");
            string code3 = prob6.NormalizarCodigoProducto(null);
            Console.WriteLine(code);
            Console.WriteLine(code2);
            Console.WriteLine(code3);
            Console.WriteLine();
        }
    }
}
