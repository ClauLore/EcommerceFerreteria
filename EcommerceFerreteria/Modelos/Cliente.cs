using EcommerceFerreteria.Abstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Modelos
{
    public class Cliente: Auditoria
    {
        private static int _nextId = 1;
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public Cliente()
        {
            Id = _nextId++;
        }
    }
}
