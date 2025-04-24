using EcommerceFerreteria.Modelos;

namespace EcommerceFerreteria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== E-Commerce Ferretería ===\n");
            SistemaEcommerceFerreteria sistema = new SistemaEcommerceFerreteria();
            CargarDatosIniciales(sistema);
        }

        private static void CargarDatosIniciales(SistemaEcommerceFerreteria sistema)
        {

        }
    }
}
