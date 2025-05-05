using EcommerceFerreteria.Modelos;
using EcommerceFerreteria.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Repositories
{
    public class VentaRepository : IVentaRepository
    {
        private List<Venta> _ventas = new List<Venta>();

        private int _nextId = 1;

        public List<Venta> ObtenerPorTipoDocumento(TipoDocumento tipoDoc)
        {
            return _ventas.Where(v => v.TipoDocumento == tipoDoc).ToList();
        }

        void IRepository<Venta>.Actualizar(Venta entidad)
        {
            var index = _ventas.FindIndex(c => c.Id == entidad.Id);
            if (index != -1)
            {
                _ventas[index] = entidad;
            }
        }

        void IRepository<Venta>.Agregar(Venta entidad)
        {
            entidad.Id = _nextId++;
            _ventas.Add(entidad);
        }

        void IRepository<Venta>.Eliminar(Venta entidad)
        {
            _ventas.Remove(entidad);

        }

        List<Venta> IVentaRepository.ObtenerPorCliente(int idCliente)
        {
            return _ventas.Where(v => v.IdCliente == idCliente).ToList();
        }


        Venta IVentaRepository.ObtenerPorDocumento(TipoDocumento tipoDoc, string serieDoc, string numeroDoc)
        {
            return _ventas.FirstOrDefault(v => v.TipoDocumento == tipoDoc && v.SerieDoc == serieDoc && v.NumeroDoc == numeroDoc);
        }

        List<Venta> IVentaRepository.ObtenerPorEstado(EstadoVenta estado)
        {
            return _ventas.Where(v => v.Estado == estado).ToList();
        }

        Venta IRepository<Venta>.ObtenerPorId(int id)
        {
            return _ventas.FirstOrDefault(v => v.Id == id);
        }

        List<Venta> IVentaRepository.ObtenerPorRangoFecha(DateOnly fechaInicio, DateOnly fechaFin)
        {
            return _ventas.Where(v => DateOnly.FromDateTime(v.FechaVenta) >= fechaInicio && DateOnly.FromDateTime(v.FechaVenta) <= fechaFin).ToList();
        }

        List<Venta> IVentaRepository.ObtenerPorTipoDocumento(TipoDocumento tipoDoc)
        {
            throw new NotImplementedException();
        }

        List<Venta> IVentaRepository.ObtenerPorVendedor(int idVendedor)
        {
            return _ventas.Where(v => v.IdVendedor == idVendedor).ToList();
        }

        List<Venta> IRepository<Venta>.ObtenerTodo()
        {
            return _ventas;
        }
    }
}
