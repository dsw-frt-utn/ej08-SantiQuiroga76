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
        }
    }
}
