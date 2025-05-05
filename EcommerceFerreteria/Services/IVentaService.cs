using EcommerceFerreteria.Modelos.Enums;
using EcommerceFerreteria.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Services
{
    public interface IVentaService
    {
        bool CrearVenta(Venta venta);
        List<Venta> ObtenerPorVendedor(int idVendedor);
        Venta ObtenerVentaPorID(int idVenta);
        List<Venta> ObtenerPorRangoFecha(DateOnly fechaInicio, DateOnly fechaFin);
        List<Venta> ObtenerPorCliente(int idCliente);
        List<Venta> ObtenerPorEstado(EstadoVenta estado);
        Venta ObtenerPorDocumento(TipoDocumento tipoDoc, string serieDoc, string numeroDoc);
        List<Venta> ObtenerPorTipoDocumento(TipoDocumento tipoDoc);
        bool AnularVenta(TipoDocumento tipoDocumento, string serieDoc, string numeroDoc);

    }
}
