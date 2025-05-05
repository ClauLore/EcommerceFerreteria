using EcommerceFerreteria.Modelos;
using EcommerceFerreteria.Modelos.Enums;
using EcommerceFerreteria.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IVentaRepository _ventaRepository;
        private readonly IProductoRepository _productoRepository;

        public ProductoService(
        IProductoRepository productoRepository,
        IVentaRepository ventaRepository)
        {
            this._productoRepository = productoRepository;
            this._ventaRepository = ventaRepository;
        }
        public List<Producto> ObtenerPorCategoria(CategoriaProducto categoria)
        {
            return _productoRepository.ObtenerPorCategoria(categoria);
        }

        public List<Producto> ProductosConStock()
        {
            return _productoRepository.ProductosConStock();
        }

        Producto IProductoService.DeshabilitarProducto(int IdProducto)
        {
            var producto = _productoRepository.ObtenerPorId(IdProducto);
            producto.Estado = Estado.INACTIVO;
            _productoRepository.Actualizar(producto);

            return producto;
        }

        Producto IProductoService.CrearProducto(string descripcion, decimal precio, int stock, CategoriaProducto categoria)
        {

           var producto = new Producto
                {
                 Descripcion = descripcion,
                 Precio = precio,
                 Stock = stock,
                 CategoriaProducto = categoria
                };
                _productoRepository.Agregar(producto);
            
            return producto;
        }

        List<Producto> IProductoService.ObtenerPorCategoria(CategoriaProducto categoria)
        {
            return _productoRepository.ObtenerPorCategoria(categoria);
        }

        List<Producto> IProductoService.ProductosConStock()
        {
            throw new NotImplementedException();
        }

        List<Producto> IProductoService.ObtenerProductos()
        {
            return _productoRepository.ObtenerTodo();
        }
    }
}
