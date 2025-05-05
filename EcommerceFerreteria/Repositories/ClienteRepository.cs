using EcommerceFerreteria.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private List<Cliente> _clientes= new List<Cliente>();

        private int _nextId = 1;
        void IRepository<Cliente>.Actualizar(Cliente entidad)
        {
           var index = _clientes.FindIndex(c=>c.Id == entidad.Id);
           if (index != -1)
           { 
                _clientes[index] = entidad;
           }
        }

        void IRepository<Cliente>.Agregar(Cliente entidad)
        {
            entidad.Id = _nextId++;
            _clientes.Add(entidad);
        }

        void IRepository<Cliente>.Eliminar(Cliente entidad)
        {
            _clientes.Remove(entidad);
        }

        Cliente IClienteRepository.ObtenerPorDNI(string dni)
        {
            return _clientes.FirstOrDefault(c => c.DNI == dni);
        }

        Cliente IClienteRepository.ObtenerPorEmail(string email)
        {
            return _clientes.FirstOrDefault(c=>c.Email==email);
        }

        Cliente IRepository<Cliente>.ObtenerPorId(int id)
        {
            return _clientes.FirstOrDefault(c => c.Id == id);
        }

        List<Cliente> IRepository<Cliente>.ObtenerTodo()
        {
           return _clientes;
        }
    }
}
