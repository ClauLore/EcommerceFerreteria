using EcommerceFerreteria.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Repositories
{
    public interface IClienteRepository: IRepository<Cliente>
    {
        Cliente ObtenerPorDNI(string dni);
        Cliente ObtenerPorEmail(string email);
    }
}
