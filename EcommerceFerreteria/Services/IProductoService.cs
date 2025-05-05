using EcommerceFerreteria.Modelos.Enums;
using EcommerceFerreteria.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Services
{
    public interface IProductoService
    {
        Producto CrearProducto(string descripcion, decimal precio, int stock, CategoriaProducto categoria);
        Producto DeshabilitarProducto(int IdProducto);
        List<Producto> ObtenerPorCategoria(CategoriaProducto categoria);
        List<Producto> ProductosConStock();
        List<Producto> ObtenerProductos();
    }
}
