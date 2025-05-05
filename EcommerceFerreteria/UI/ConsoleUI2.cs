using EcommerceFerreteria.Modelos;
using EcommerceFerreteria.Modelos.Enums;
using EcommerceFerreteria.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.UI
{
    public class ConsoleUI2
    {
        private readonly IProductoService _productoService;
        private readonly IVendedorService _vendedorService;
        private readonly IClienteService _clienteService;
        private readonly IVentaService _ventaService;



        public ConsoleUI2(IProductoService productoService, IVendedorService vendedorService,
        IClienteService clienteService, IVentaService ventaService)
        {
            _productoService = productoService;
            _vendedorService = vendedorService;
            _clienteService = clienteService;
            _ventaService = ventaService;
        }

        public void Iniciar()
        {
            try
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
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
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
            while (_isAlive)
            {
                Console.WriteLine("=== VENTAS ===");
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
           

            while (_isAlive)
            {
                Console.WriteLine("=== CLIENTES ===");
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
            Console.WriteLine("======REGISTRAR CLIENTE========");
            Console.WriteLine("Nombres:");
            var nombres = Console.ReadLine();

            if (nombres == null || nombres.Trim().Length == 0)
            {
                Console.WriteLine("Nombre inválido");
                return;
            }

            Console.WriteLine("Apellidos:");
            var apellidos = Console.ReadLine();

            if (apellidos == null || apellidos.Trim().Length == 0)
            {
                Console.WriteLine("Apellidos inválidos");
                return;
            }

            Console.WriteLine("DNI:");
            var dni = Console.ReadLine();

            if (dni == null || dni.Trim().Length == 0 || !int.TryParse(Console.ReadLine(), out int _))
            {
                Console.WriteLine("DNI inválido");
                return;
            }

            Console.WriteLine("Email:");
            var email = Console.ReadLine();

            if (email == null || email.Trim().Length == 0)
            {
                Console.WriteLine("Email inválido");
                return;
            }

            var cliente = _clienteService.ObtenerOCrearCliente(nombres, apellidos, dni, email);

            if (cliente != null)
            {
                if (cliente.Id > 0)
                    Console.WriteLine($"El cliente se creó satisfactoriamente con el ID :{cliente.Id}");
                else
                    Console.WriteLine("Ocurrió un error al crear al cliente!");
            }

            Console.WriteLine("\nPresiones cualquier tecla para continuar...");
            Console.ReadKey();

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
            Console.WriteLine("======REGISTRAR VENDEDOR========");
            Console.WriteLine("Nombres:");
            var nombres = Console.ReadLine();

            if (nombres == null || nombres.Trim().Length == 0)
            {
                Console.WriteLine("Nombre inválido");
                return;
            }

            Console.WriteLine("Apellidos:");
            var apellidos = Console.ReadLine();

            if (apellidos == null || apellidos.Trim().Length == 0)
            {
                Console.WriteLine("Apellidos inválidos");
                return;
            }

            Console.WriteLine("DNI:");
            var dni = Console.ReadLine();

            if (dni == null || dni.Trim().Length == 0 || !int.TryParse(Console.ReadLine(), out int _))
            {
                Console.WriteLine("DNI inválido");
                return;
            }

            Console.WriteLine("Email:");
            var email = Console.ReadLine();

            if (email == null || email.Trim().Length == 0)
            {
                Console.WriteLine("Email inválido");
                return;
            }

            var vendedor = _vendedorService.ObtenerOCrearVendedor(nombres, apellidos, dni, email);

            if (vendedor != null)
            {
                if (vendedor.Id > 0)
                    Console.WriteLine($"El vendedor se creó satisfactoriamente con el ID :{vendedor.Id}");
                else
                    Console.WriteLine("Ocurrió un error al crear al vendedor!");
            }

            Console.WriteLine("\nPresiones cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private void MantenimientoProductos()
        {
            bool _isAlive = true;
            Console.Clear();

            while (_isAlive)
            {
                Console.WriteLine("=== PRODUCTOS ===");
                Console.WriteLine("1. Registrar Producto");
                Console.WriteLine("2. Deshabilitar Producto");
                Console.WriteLine("3. Obtener Productos por Categoría");
                Console.WriteLine("4. Listar Productos");
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
                        ListarProductos();
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

        private void ListarProductos()
        {
            Console.Clear();
            Console.WriteLine("=========LISTAR PRODUCTOS============");

            var productos = _productoService.ObtenerProductos();

            if (productos.Count == 0)
            {
                Console.WriteLine("No se ha registrado ningún producto...");
                Console.WriteLine("\nPresiones cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            foreach (var prod in productos)
            {
                Console.WriteLine($"ID: {prod.Descripcion},Precio: {prod.Precio},Stock: {prod.Stock},Categoría: {prod.CategoriaProducto}, Estado: {prod.Estado}");

            }

            Console.WriteLine("\nPresiones cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private void ObtenerProductosPorCategorias()
        {
            Console.Clear();
            Console.WriteLine("=========LISTAR PRODUCTOS POR CATEGORÍA============");
            Console.WriteLine("Seleccionar Categoría:");
            int index = 0;
            foreach (var categoria1 in Enum.GetValues<CategoriaProducto>())
            {
                Console.WriteLine($"{index++}. {categoria1}");
            }
            Console.Write("Ingrese el identificador de la categoría: ");

            if (!Enum.TryParse(Console.ReadLine(), out CategoriaProducto categoria))
                categoria = CategoriaProducto.OTRO;

            var productosCategoria= _productoService.ObtenerPorCategoria(categoria);

            if (productosCategoria.Count == 0)
            {
                Console.WriteLine($"No se ha registrado ´ningún producto para la categoría { categoria}");
                Console.Clear();
                return;

            }
            
            foreach( var prod in productosCategoria)
            {
                Console.WriteLine($"ID: {prod.Descripcion},Precio: {prod.Precio},Stock: {prod.Stock},Categoría: {prod.CategoriaProducto}, Estado: {prod.Estado}");
            }
            Console.WriteLine("\nPresiones cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private void RegistrarProducto()
        {
            Console.WriteLine("======REGISTRAR PRODUCTO========");
            Console.WriteLine("Descripción:");
            var descripcion = Console.ReadLine();

            if (descripcion == null || descripcion.Trim().Length == 0)
            {
                Console.WriteLine("Descripción inválida");
                return;
            }

            Console.WriteLine("Precio:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal precio))
            {
                Console.WriteLine("Precio inválido");
                return;
            }

            Console.WriteLine("Stock:");
            if (!int.TryParse(Console.ReadLine(), out int stock))
            {
                Console.WriteLine("Stock inválido");
                return;
            }

            Console.WriteLine("Seleccione Categoría:");
            var index = 0;
            foreach(var categoria in Enum.GetValues(typeof(CategoriaProducto)))
            {
                Console.WriteLine($"{ index++} - { categoria}");
            }
            Console.Write("Ingrese una opción (Identificador): ");


            if (!Enum.TryParse(Console.ReadLine(), out CategoriaProducto categoriaIng))
            {
                Console.WriteLine("Categoría inválida.");
                return;
            }


            var producto = _productoService.CrearProducto(descripcion,precio,stock, categoriaIng);

            if (producto != null)
            {
                if (producto.Id > 0)
                    Console.WriteLine($"El producto se creó satisfactoriamente con el ID :{producto.Id}");
                else
                    Console.WriteLine("Ocurrió un error al crear el producto!");
            }

            Console.WriteLine("\nPresiones cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

       

        private void ObtenerVentasPorVendedor()
        {
            throw new NotImplementedException();
        }

        private void DeshabilitarProducto()
        {
            Console.WriteLine("======DESHABILITAR PRODUCTO========");

            var productos = _productoService.ProductosConStock();
            if (productos.Count == 0)
            {
                Console.WriteLine("No se ha registrado ningún producto...");
                Console.WriteLine("\nPresiones cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            foreach (var prod in productos)
            {
                Console.WriteLine($"ID: {prod.Descripcion},Precio: {prod.Precio},Stock: {prod.Stock},Categoría: {prod.CategoriaProducto}, Estado: {prod.Estado}");

            }

            Console.WriteLine("Ingrese el identificador del producto a deshabilitar:");
            if (!int.TryParse(Console.ReadLine(), out int productoIndex) ||
            productoIndex < 1 || productoIndex > productos.Count)
            {
                Console.WriteLine("Selección de producto inválida.");
                return;
            }

            var product= _productoService.DeshabilitarProducto(productoIndex);

            if (product != null)
            {
                Console.WriteLine("El producto se deshabilitó correctamente!");
            }
            else
            {
                Console.WriteLine("Ocurrió un error al deshabilitar el producto!");
            }


            Console.WriteLine("\nPresiones cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        }

        private void RegistrarVenta()
        {
            Console.WriteLine("======REGISTRAR VENTA========");
            Console.WriteLine("Seleccione Tipo Documento:");
            var index = 0;
            foreach (var tipoDoc in Enum.GetValues(typeof(TipoDocumento)))
            {
                Console.WriteLine($"{index++} - {tipoDoc}");
            }
            Console.Write("Ingrese una opción (Identificador): ");


            if (!Enum.TryParse(Console.ReadLine(), out TipoDocumento tipoDocIng))
            {
                Console.WriteLine("Tipo Documento inválido.");
                return;
            }

            Console.WriteLine("Serie Documento:");
            var serie = Console.ReadLine();
            if (serie.Trim().Length == 0)
            {
                Console.WriteLine("Serie inválida");
                return;
            }

            Console.WriteLine("Número Documento:");
            var numero = Console.ReadLine();
            if (numero.Trim().Length == 0)
            {
                Console.WriteLine("Número Documento inválido");
                return;
            }

            Console.Write("Fecha venta (MM/DD/YYYY HH:MM): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime fechaVenta))
            {
                Console.WriteLine("Fecha inválida.");
                return;
            }


            Console.WriteLine("Ingrese el DNI del Cliente:");
            var dni = Console.ReadLine();
            if (!int.TryParse(dni, out int _) ||dni.Trim().Length<8 || dni.Trim().Length > 8)
            {
                Console.WriteLine("DNI inválido");
                return;
            }

            var cliente = _clienteService.ObtenerClientePorDNI(dni);

            if (cliente != null)
            {
                Console.WriteLine($"{cliente.Nombres} {cliente.Apellidos}");
            }
            else
            {
                Console.WriteLine("El cliente no existe");
                Console.WriteLine("Ingrese nombres del cliente:");
                var nombresCliente = Console.ReadLine();
                if (nombresCliente == null || nombresCliente.Trim().Length == 0)
                {
                    Console.WriteLine("Nombres inválido");
                    return;
                }
                Console.WriteLine("Ingrese apellidos del cliente:");
                var apellidosCliente = Console.ReadLine();
                if (apellidosCliente == null || apellidosCliente.Trim().Length == 0)
                {
                    Console.WriteLine("Apellidos inválido");
                    return;
                }

                cliente = _clienteService.ObtenerOCrearCliente(nombresCliente, apellidosCliente, dni, "");


            }
            bool regItem = true;
            var venta = new Venta();
            var items = new List<VentaDetalle>();
            int itemm = 1;
            while (regItem)
            { 
            //Registro de Venta Detalle
            var item = new VentaDetalle();
            Console.WriteLine("Ingrese Item:"+ itemm.ToString("000"));

            Console.WriteLine("Seleccione Producto: ");

            var productos = _productoService.ProductosConStock();

            if (productos.Count == 0)
            {
                    Console.WriteLine("No se ha registrado ningún producto... no se puede continuar con el registro de venta.");
                    Console.WriteLine("\nPresiones cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    return;
            }    

            foreach(var prod in productos)
            {
                Console.WriteLine($"ID:{prod.Id}, Descripción: {prod.Descripcion},Precio: {prod.Precio},Stock: {prod.Stock},Categoría: {prod.CategoriaProducto}");

            }
            Console.WriteLine("Ingrese ID del producto: ");
            if (!int.TryParse(Console.ReadLine(), out int productoIndex) ||
             productoIndex < 1 || productoIndex > productos.Count)
            {
                Console.WriteLine("Producto seleccionado inválido.");
                return;
            }

            Console.WriteLine("Ingrese Cantidad: ");
            if (!int.TryParse(Console.ReadLine(), out int cantidad))
            {
                Console.WriteLine("Cantidad inválida");
                return;
            }

            var productoSel = _productoService.ObtenerProductoPorID(productoIndex);

            Console.WriteLine("Precio unitario: " + productoSel.Precio.ToString("F2"));
            Console.WriteLine("Precio venta: " + (productoSel.Precio * cantidad).ToString("F2"));


            item.Item = itemm;
            item.Cantidad= cantidad;
            item.IdProducto = productoSel.Id;
            item.PrecioVenta=productoSel.Precio;
            item.Subtotal= cantidad*productoSel.Precio;

            items.Add(item);
            itemm++;

            Console.WriteLine("¿Desea ingresar otro Item? y/n: ");
            var respuesta = Console.ReadLine();

            if (respuesta.ToLower() != "y")
                {
                    regItem=false;
                }

            }



            decimal total = 0;
            foreach(var item2 in items)
            {
                total = total + item2.Subtotal;
            }

            venta.TipoDocumento = tipoDocIng;
            venta.SerieDoc = serie;
            venta.NumeroDoc = numero;
            venta.IdCliente = cliente.Id;
            venta.FechaVenta = fechaVenta;
            venta.IdVendedor = 1;
            venta.Items = items;
            venta.Total = total;

            var confirmacion = _ventaService.CrearVenta(venta);



            if (confirmacion)
                Console.WriteLine($"Total Venta S/. "+ venta.Total.ToString("F2"));

            Console.WriteLine($"La venta se registró satisfactoriamente!");
           else
                Console.WriteLine("Ocurrió un error al registrar la venta!");
            

            Console.WriteLine("\nPresiones cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
