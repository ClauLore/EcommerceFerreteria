using EcommerceFerreteria.Modelos;
using EcommerceFerreteria.Repositories;
using EcommerceFerreteria.Services;
using EcommerceFerreteria.UI;

namespace EcommerceFerreteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
   

           var clienteService = new ClienteService(new ClienteRepository(), new VentaRepository());
           var vendedorService = new VendedorService(new VendedorRepository(), new VentaRepository());
           var productoService = new ProductoService(new ProductoRepository(), new VentaRepository());
           var ventaService = new VentaService(new ClienteRepository(), new VentaRepository());

            var ui = new ConsoleUI(productoService, vendedorService, clienteService,ventaService);

            ui.Iniciar();
        }  
    }
}
