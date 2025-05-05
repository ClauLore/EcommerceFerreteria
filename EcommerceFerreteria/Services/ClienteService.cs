using EcommerceFerreteria.Modelos;
using EcommerceFerreteria.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EcommerceFerreteria.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IVentaRepository _ventaRepository;

        public ClienteService(
        IClienteRepository clienteRepository,
        IVentaRepository ventaRepository)
        {
            this._clienteRepository = clienteRepository;
            this._ventaRepository = ventaRepository;
        }


        Cliente IClienteService.ObtenerClientePorId(int id)
        {
            return _clienteRepository.ObtenerPorId(id);
        }

        Cliente IClienteService.ObtenerClientePorDNI(string dni)
        {
            return _clienteRepository.ObtenerPorDNI(dni);
        }

        Cliente IClienteService.ObtenerClientePorEmail(string email)
        {
            return _clienteRepository.ObtenerPorEmail(email);
        }

        List<Cliente> IClienteService.ObtenerClientes()
        {
            return _clienteRepository.ObtenerTodo();
        }

        Cliente IClienteService.ObtenerOCrearCliente(string nombres, string apellidos, string DNI, string email)
        {
            var cliente = _clienteRepository.ObtenerPorDNI(DNI);

            if (cliente == null)
            {
                cliente = new Cliente
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    DNI = DNI,
                    Email = email

                };
                _clienteRepository.Agregar(cliente);
            }
            return cliente;
        }

        List<Venta> IClienteService.ObtenerVentasPorCliente(int clienteId)
        {
           return _ventaRepository.ObtenerPorCliente(clienteId);
        }

    }
}
