using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Interfaces
{
    public interface IProducto
    {
        void AgregarProducto(EcommerceFerreteria sistema);
        void ModificarProducto(EcommerceFerreteria sistema);
        void EliminarProducto(EcommerceFerreteria sistema);
        void ListarProducto(EcommerceFerreteria sistema);
        void ObtenerProductoId(EcommerceFerreteria sistema);

    }
}
