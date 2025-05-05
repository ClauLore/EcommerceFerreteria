using EcommerceFerreteria.Interfaces;
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
    public class VendedorServicio : IVendedorServicio
    {
        private readonly IVendedorRepository _vendedorRepository;
        private readonly IVentaRepository _ventaRepository;

        public VendedorServicio(
        IVendedorRepository vendedorRepository,
        IVentaRepository ventaRepository)
        {
            this._vendedorRepository = vendedorRepository;
            this._ventaRepository = ventaRepository;
        }
        Vendedor IVendedorServicio.ObtenerOCrearVendedor(string nombres, string apellidos, string DNI, string email)
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

        Vendedor IVendedorServicio.DeshabilitarVendedor(int idVendedor)
        {
            var vendedor = _vendedorRepository.ObtenerPorId(idVendedor);
            vendedor.Estado = Estado.INACTIVO;
            _vendedorRepository.Actualizar(vendedor);

            return vendedor;
        }

        List<Vendedor> IVendedorServicio.ObtenerVendedores()
        {
            return _vendedorRepository.ObtenerTodo();
        }

        List<Vendedor> IVendedorServicio.ObtenerVendedorPorEstado(Estado estado)
        {
            return _vendedorRepository.ObtenerPorEstado(estado);
        }

        Vendedor IVendedorServicio.ObtenerVendedorPorId(int id)
        {
            return _vendedorRepository.ObtenerPorId(id);
        }

        List<Venta> IVendedorServicio.ObtenerVentasPorVendedor(int vendedorId)
        {
            return _ventaRepository.ObtenerPorVendedor(vendedorId);
        }
    }
}
