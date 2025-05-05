using EcommerceFerreteria.Modelos;
using EcommerceFerreteria.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Services
{
    public interface IVendedorServicio
    {
        Vendedor ObtenerOCrearVendedor(string nombres, string apellidos, string DNI, string email);
        Vendedor ObtenerVendedorPorId(int id);
        List<Vendedor> ObtenerVendedores();
        List<Vendedor> ObtenerVendedorPorEstado(Estado estado);
        List<Venta> ObtenerVentasPorVendedor(int vendedorId);
        Vendedor DeshabilitarVendedor(int idVendedor);

    }
}
