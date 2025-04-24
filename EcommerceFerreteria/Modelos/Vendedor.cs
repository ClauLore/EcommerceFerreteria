using EcommerceFerreteria.Abstracta;
using EcommerceFerreteria.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Modelos
{
    public class Vendedor:CamposAuditoria
    {
        private static int _nextId = 1;

        public int Id { get; set; } 
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public Estado Estado { get; set; }

        public Vendedor()
        {
            Id = _nextId++;
        }
    }
}
