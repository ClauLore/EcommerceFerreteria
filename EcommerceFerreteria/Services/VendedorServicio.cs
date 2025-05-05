using EcommerceFerreteria.Modelos;
using EcommerceFerreteria.Modelos.Enums;
using EcommerceFerreteria.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Services
{
    public class VendedorService : IVendedorService
    {
        private readonly IVendedorRepository _vendedorRepository;
        private readonly IVentaRepository _ventaRepository;

        public VendedorService(
        IVendedorRepository vendedorRepository,
        IVentaRepository ventaRepository)
        {
            this._vendedorRepository = vendedorRepository;
            this._ventaRepository = ventaRepository;
        }
        Vendedor IVendedorService.ObtenerOCrearVendedor(string nombres, string apellidos, string DNI, string email)
        {
            var vendedor = _vendedorRepository.ObtenerPorDNI(DNI);

            if (vendedor == null)
            {
                vendedor = new Vendedor
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    DNI = DNI,
                    Email = email

                };
                _vendedorRepository.Agregar(vendedor);
            }
            return vendedor;
        }

        Vendedor IVendedorService.DeshabilitarVendedor(int idVendedor)
        {
            var vendedor = _vendedorRepository.ObtenerPorId(idVendedor);
            vendedor.Estado = Estado.INACTIVO;
            _vendedorRepository.Actualizar(vendedor);

            return vendedor;
        }

        List<Vendedor> IVendedorService.ObtenerVendedores()
        {
            return _vendedorRepository.ObtenerTodo();
        }

        List<Vendedor> IVendedorService.ObtenerVendedorPorEstado(Estado estado)
        {
            return _vendedorRepository.ObtenerPorEstado(estado);
        }

        Vendedor IVendedorService.ObtenerVendedorPorId(int id)
        {
            return _vendedorRepository.ObtenerPorId(id);
        }

        List<Venta> IVendedorService.ObtenerVentasPorVendedor(int vendedorId)
        {
            return _ventaRepository.ObtenerPorVendedor(vendedorId);
        }
    }
}
