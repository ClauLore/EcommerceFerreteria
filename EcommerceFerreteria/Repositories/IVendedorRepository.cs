using EcommerceFerreteria.Modelos;
using EcommerceFerreteria.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Repositories
{
    public interface IVendedorRepository:IRepository<Vendedor>
    {
        Vendedor ObtenerPorDNI(string dni);
        List<Vendedor> ObtenerPorEstado(Estado estado);
    }
}
