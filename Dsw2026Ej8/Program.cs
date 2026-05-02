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
        }
    }
}
