namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("==== PRUEBA PROBLEMA 1 =====");
            ProductHelper helper = new ProductHelper();
            String etiqueta = helper.ObtenerEtiquetaProducto(1045, "Teclado mecanico", 5764823m);
            Console.WriteLine(etiqueta);
            Console.WriteLine();
        }
    }
}
