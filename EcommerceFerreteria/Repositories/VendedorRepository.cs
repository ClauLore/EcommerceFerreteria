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
    public class VendedorRepository : IVendedorRepository
    {
        private List<Vendedor> _vendedores = new List<Vendedor>();
        private int _nextId = 1;

        public VendedorRepository() 
        { 
            _vendedores.Add(new Vendedor { Id = _nextId, Nombres = "Rodolfo", Apellidos = "Rosales", DNI = "25725485", Email = "rrosales@ferreteria.com.pe", Estado = Estado.ACTIVO });
        }

        void IRepository<Vendedor>.Actualizar(Vendedor entidad)
        {
           var index = _vendedores.FindIndex(v=> v.Id==entidad.Id);
           if (index != -1)
           {
                _vendedores[index] = entidad;
           }
        }

        void IRepository<Vendedor>.Agregar(Vendedor entidad)
        {
            entidad.Id = _nextId++;
            _vendedores.Add(entidad);
        }

        void IRepository<Vendedor>.Eliminar(Vendedor entidad)
        {
            _vendedores.Remove(entidad);
        }

        Vendedor IVendedorRepository.ObtenerPorDNI(string dni)
        {
            return _vendedores.FirstOrDefault(v => v.DNI == dni);
        }

        List<Vendedor> IVendedorRepository.ObtenerPorEstado(Estado estado)
        {
            return _vendedores.Where(v => v.Estado == estado).ToList();
        }

        Vendedor IRepository<Vendedor>.ObtenerPorId(int id)
        {
            return _vendedores.FirstOrDefault(v => v.Id == id);
        }

        List<Vendedor> IRepository<Vendedor>.ObtenerTodo()
        {
           return _vendedores;
        }
    }
}
