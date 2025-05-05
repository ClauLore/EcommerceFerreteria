using EcommerceFerreteria.Modelos;
using EcommerceFerreteria.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Repositories
{
    public interface IProductoRepository:IRepository<Producto>
    {
        List<Producto> ObtenerPorCategoria(CategoriaProducto categoria);
        List<Producto> ProductosConStock();

    }
}
