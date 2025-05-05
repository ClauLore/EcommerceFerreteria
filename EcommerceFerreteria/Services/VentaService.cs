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

        public bool CrearVenta(Venta venta)
        {
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

        bool IVentaService.AnularVenta(TipoDocumento tipoDocumento, string serieDoc, string numeroDoc)
        {
            throw new NotImplementedException();
        }

        bool IVentaService.CrearVenta(Venta venta)
        {
            throw new NotImplementedException();
        }

        List<Venta> IVentaService.ObtenerPorCliente(int idCliente)
        {
            throw new NotImplementedException();
        }

        Venta IVentaService.ObtenerPorDocumento(TipoDocumento tipoDoc, string serieDoc, string numeroDoc)
        {
            throw new NotImplementedException();
        }

        List<Venta> IVentaService.ObtenerPorEstado(EstadoVenta estado)
        {
            throw new NotImplementedException();
        }

        Venta IVentaService.ObtenerVentaPorID(int idVenta)
        {
        return _ventaRepository.ObtenerPorId(idVenta);
        }

        List<Venta> IVentaService.ObtenerPorRangoFecha(DateOnly fechaInicio, DateOnly fechaFin)
        {
            throw new NotImplementedException();
        }

        List<Venta> IVentaService.ObtenerPorTipoDocumento(TipoDocumento tipoDoc)
        {
            throw new NotImplementedException();
        }

        List<Venta> IVentaService.ObtenerPorVendedor(int idVendedor)
        {
            throw new NotImplementedException();
        }
    }
}
