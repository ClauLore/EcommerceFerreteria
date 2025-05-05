using EcommerceFerreteria.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.UI
{
    public class ConsoleUI
    {
        private readonly IProductoService _productoService;
        private readonly IVendedorService _vendedorService;
        private readonly IClienteService _clienteService;
        private readonly IVentaService _ventaService;

        private bool _isAlive = true;

        public ConsoleUI(IProductoService productoService, IVendedorService vendedorService,
        IClienteService clienteService, IVentaService ventaService)
        {
            _productoService = productoService;
            _vendedorService = vendedorService;
            _clienteService = clienteService;
            _ventaService = ventaService;
        }

        public void Iniciar()
        {
            Console.WriteLine("=== Sistema de Ventas E-commerce Ferretería ===");

            while (_isAlive)
            {
               MenuPrincipal();

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        MantenimientoProductos();
                        break;
                    case "2":
                        ManetenimientoVendedores();
                        break;
                    case "3":
                        MentenimientoClientes();
                        break;
                    case "4":
                        MantenimientoVentas();
                        break;
                    case "0":
                        _isAlive = false;
                        Console.WriteLine("Saliendo del Sistema de Ventas de E-commerce Ferretería!");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta, vuelva a intentarlo por favor...");
                        break;
                }

                Console.WriteLine("\nPresiones cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void MantenimientoVentas()
        {
            throw new NotImplementedException();
        }

        private void MentenimientoClientes()
        {
            throw new NotImplementedException();
        }

        private void ManetenimientoVendedores()
        {
            throw new NotImplementedException();
        }

        private void MenuPrincipal()
        {
            Console.WriteLine("\n=== Menú Principal ===");
            Console.WriteLine("1. Productos");
            Console.WriteLine("2. Vendedores");
            Console.WriteLine("3. Clientes");
            Console.WriteLine("4. Ventas");
            Console.WriteLine("0. Salir");
            Console.Write("Ingrese una opción: ");
        }

        private void MantenimientoProductos()
        {
            Console.Clear();
            Console.WriteLine("=== PRODUCTOS ===");
            Console.WriteLine("1. Registrar Producto");
            Console.WriteLine("2. Deshabilitar Producto");
            Console.WriteLine("3. Obtener Productos por Categoría");
            Console.WriteLine("4. Listar Productos con Stock");
            Console.Write("Ingrese una opción: ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    RegistrarProducto();
                    break;
                case "2":
                    DeshabilitarProducto();
                    break;
                case "3":
                    ObtenerProductosPorCategoría();
                    break;
                case "4":
                    ListarProductosConStock();
                    break;
                default:
                    Console.WriteLine("Opción incorrecta!");
                    break;
            }

        }

        private void ListarProductosConStock()
        {
            throw new NotImplementedException();
        }

        private void ObtenerProductosPorCategoría()
        {
            throw new NotImplementedException();
        }

        private void DeshabilitarProducto()
        {
            throw new NotImplementedException();
        }

        private void RegistrarProducto()
        {
            throw new NotImplementedException();
        }
    }
}
