using EcommerceFerreteria.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Services
{
    public interface IClienteService
    {
        Cliente ObtenerOCrearCliente(string nombres,string apellidos, string DNI, string email);
        Cliente ObtenerClientePorId(int id);
        List<Cliente>ObtenerClientes();
        Cliente ObtenerClientePorDNI(string dni);
        Cliente ObtenerClientePorEmail(string email);
        List<Venta> ObtenerVentasPorCliente(int clienteId);
    }
}
