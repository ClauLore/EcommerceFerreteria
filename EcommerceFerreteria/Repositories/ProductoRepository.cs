using EcommerceFerreteria.Modelos;
using EcommerceFerreteria.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private List<Producto> _productos = new List<Producto>();
        private int _nextId = 1;

        void IRepository<Producto>.Actualizar(Producto entidad)
        {
            var index = _productos.FindIndex(c => c.Id == entidad.Id);
            if (index != -1)
            {
                _productos[index] = entidad;
            }
        }

        void IRepository<Producto>.Agregar(Producto entidad)
        {
           entidad.Id = _nextId++;
           _productos.Add(entidad);
        }

        void IRepository<Producto>.Eliminar(Producto entidad)
        {
           _productos.Remove(entidad);
        }

        List<Producto> IProductoRepository.ObtenerPorCategoria(CategoriaProducto categoria)
        {
          return _productos.Where(p=> p.CategoriaProducto == categoria).ToList();
        }

        Producto IRepository<Producto>.ObtenerPorId(int id)
        {
          return _productos.FirstOrDefault(p=> p.Id==id);
        }

        List<Producto> IRepository<Producto>.ObtenerTodo()
        {
            return _productos;
        }

        List<Producto> IProductoRepository.ProductosConStock()
        {
            return _productos.Where(p => p.Stock > 0 && p.Estado==Estado.ACTIVO).ToList();
        }
    }
}
