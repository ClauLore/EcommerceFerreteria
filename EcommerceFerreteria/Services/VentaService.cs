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
    public class VentaService : IVentaService
    {
        private readonly IVentaRepository _ventaRepository;

        public VentaService(
        IClienteRepository clienteRepository,
        IVentaRepository ventaRepository)
        {
            this._ventaRepository = ventaRepository;
        }

        public bool AnularVenta(TipoDocumento tipoDocumento, string serieDoc, string numeroDoc)
        {
            var venta=_ventaRepository.ObtenerPorDocumento(tipoDocumento, serieDoc, numeroDoc);
            venta.Estado = EstadoVenta.ANULADO;
            _ventaRepository.Actualizar(venta);
            return true;
        }

        public bool CrearVenta(TipoDocumento tipoDocumento, string serieDoc, string numeroDoc, int IdCliente, DateTime FechaVenta, decimal Total, int IdVendedor, List<VentaDetalle> Items)
        {
              var  venta = new Venta
                {
                  TipoDocumento = tipoDocumento,
                  SerieDoc = serieDoc,
                  NumeroDoc = numeroDoc,
                  IdCliente = IdCliente,
                  FechaVenta = FechaVenta,
                  Total = Total,
                  IdVendedor = IdVendedor,
                  Items = Items

                };
                _ventaRepository.Agregar(venta);
            
            return true;
        }

        public List<Venta> ObtenerPorCliente(int idCliente)
        {
            return _ventaRepository.ObtenerPorCliente(idCliente);
        }

        public Venta ObtenerPorDocumento(TipoDocumento tipoDoc, string serieDoc, string numeroDoc)
        {
            return _ventaRepository.ObtenerPorDocumento(tipoDoc,serieDoc,numeroDoc);
        }

        public List<Venta> ObtenerPorEstado(EstadoVenta estado)
        {
            return _ventaRepository.ObtenerPorEstado(estado);
        }

        public List<Venta> ObtenerPorRangoFecha(DateOnly fechaInicio, DateOnly fechaFin)
        {
            return _ventaRepository.ObtenerPorRangoFecha(fechaInicio,fechaFin);
        }

        public List<Venta> ObtenerPorTipoDocumento(TipoDocumento tipoDoc)
        {
            return _ventaRepository.ObtenerPorTipoDocumento(tipoDoc);
        }

        public List<Venta> ObtenerPorVendedor(int idVendedor)
        {
            return _ventaRepository.ObtenerPorVendedor(idVendedor);
        }
    }
}
