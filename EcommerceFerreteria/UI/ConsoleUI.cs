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
            Console.Clear();
            Console.WriteLine("=== Sistema de Ventas E-commerce Ferretería ===");
            bool _isAlive = true;
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

        private void MantenimientoVentas()
        {
            bool _isAlive = true;
            Console.Clear();
            Console.WriteLine("=== VENTAS ===");

            while (_isAlive)
            {
                
                Console.WriteLine("1. Registrar Venta");
                Console.WriteLine("2. Anular Venta");
                Console.WriteLine("3. Obtener Ventas por Vendedor");
                Console.WriteLine("4. Obtener Ventas por Cliente");
                Console.WriteLine("5. Obtener Venta por Documento");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese una opción: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        RegistrarVenta();
                        break;
                    case "2":
                        AnularVenta();
                        break;
                    case "3":
                        ObtenerVentasPorVendedor();
                        break;
                    case "4":
                        ObtenerVentasPorCliente();
                        break;
                    case "5":
                        ObtenerVentasPorDocumento();
                        break;
                    case "0":
                        _isAlive = false;
                        Console.WriteLine("Saliendo del Mantenimiento de Ventas");
                        Iniciar();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta!");
                        break;
                }
            }
        }

        private void ObtenerVentasPorDocumento()
        {
            throw new NotImplementedException();
        }

        private void ObtenerVentasPorCliente()
        {
            throw new NotImplementedException();
        }

        private void AnularVenta()
        {
            throw new NotImplementedException();
        }

        private void MentenimientoClientes()
        {
            bool _isAlive = true;
            Console.Clear();
            Console.WriteLine("=== CLIENTES ===");

            while (_isAlive)
            {

                Console.WriteLine("1. Registrar Cliente");
                Console.WriteLine("2. Deshabilitar Cliente");
                Console.WriteLine("3. Obtener Cliente por DNI");
                Console.WriteLine("4. Listar Ventas por Cliente");
                Console.WriteLine("5. Listado Clientes");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese una opción: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        RegistrarCliente();
                        break;
                    case "2":
                        DeshabilitarCliente();
                        break;
                    case "3":
                        ObtenerClientePorDNI();
                        break;
                    case "4":
                        ObtenerVentasPorCliente();
                        break;
                    case "5":
                        ObtenerListadoClientes();
                        break;
                    case "0":
                        _isAlive = false;
                        Console.WriteLine("Saliendo del Mantenimiento de Clientes");
                        Iniciar();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta!");
                        break;
                }
            }
        }

        private void ObtenerListadoClientes()
        {
            throw new NotImplementedException();
        }

        private void ObtenerClientePorDNI()
        {
            throw new NotImplementedException();
        }

        private void DeshabilitarCliente()
        {
            throw new NotImplementedException();
        }

        private void RegistrarCliente()
        {
            throw new NotImplementedException();
        }

        private void ManetenimientoVendedores()
        {
            bool _isAlive = true;
            Console.Clear();
            Console.WriteLine("=== VENDEDORES ===");

            while (_isAlive)
            {

                Console.WriteLine("1. Registrar Vendedor");
                Console.WriteLine("2. Deshabilitar Vendedor");
                Console.WriteLine("3. Obtener Vendedor por DNI");
                Console.WriteLine("4. Listar Ventas por Vendedor");
                Console.WriteLine("5. Listado Vendedores");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese una opción: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        RegistrarVendedor();
                        break;
                    case "2":
                        DeshabilitarVendedor();
                        break;
                    case "3":
                        ObtenerVendedorPorDNI();
                        break;
                    case "4":
                        ObtenerVentasPorCliente();
                        break;
                    case "5":
                        ObtenerListadoVendedores();
                        break;
                    case "0":
                        _isAlive = false;
                        Console.WriteLine("Saliendo del Mantenimiento de Clientes");
                        Iniciar();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta!");
                        break;
                }
            }
        }

        private void ObtenerListadoVendedores()
        {
            throw new NotImplementedException();
        }

        private void ObtenerVendedorPorDNI()
        {
            throw new NotImplementedException();
        }

        private void DeshabilitarVendedor()
        {
            throw new NotImplementedException();
        }

        private void RegistrarVendedor()
        {
            throw new NotImplementedException();
        }

        private void MantenimientoProductos()
        {
            bool _isAlive = true;
            Console.Clear();
            Console.WriteLine("=== PRODUCTOS ===");

            while (_isAlive)
            {
                Console.WriteLine("1. Registrar Producto");
                Console.WriteLine("2. Deshabilitar Producto");
                Console.WriteLine("3. Obtener Productos por Categoría");
                Console.WriteLine("4. Listar Productos con Stock");
                Console.WriteLine("0. Salir");
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
                        ObtenerProductosPorCategorias();
                        break;
                    case "4":
                        ListarProductosConStock();
                        break;
                    case "0":
                        _isAlive = false;
                        Console.WriteLine("Saliendo del Mantenimiento de Productos");
                        Iniciar();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta!");
                        break;
                }
            }

        }

        private void ObtenerProductosPorCategorias()
        {
            throw new NotImplementedException();
        }

        private void RegistrarProducto()
        {
            throw new NotImplementedException();
        }

        private void ListarProductosConStock()
        {
            throw new NotImplementedException();
        }

        private void ObtenerVentasPorVendedor()
        {
            throw new NotImplementedException();
        }

        private void DeshabilitarProducto()
        {
            throw new NotImplementedException();
        }

        private void RegistrarVenta()
        {
            throw new NotImplementedException();
        }
    }
}
