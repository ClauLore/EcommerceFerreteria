using EcommerceFerreteria.Modelos;
using EcommerceFerreteria.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Repositories
{
    public interface IVentaRepository: IRepository<Venta>
    {
        List<Venta> ObtenerPorVendedor(int idVendedor);
        List<Venta> ObtenerPorRangoFecha(DateOnly fechaInicio , DateOnly fechaFin);
        //List<Producto> ObtenerProductosMasVendido();
        List<Venta> ObtenerPorCliente(int idCliente);

        List<Venta> ObtenerPorEstado(EstadoVenta estado);

    }
}
