using EcommerceFerreteria.Abstracta;
using EcommerceFerreteria.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Modelos
{
    public class Vendedor:Persona
    {
        public int Id { get; set; } 
        public Estado Estado { get; set; } = Estado.ACTIVO;
        
        public override string ToString()
        {
            return $"Vendedor # {Id}: Nombres y Apellidos: {Nombres} {Apellidos}, DNI: {DNI}, Estado: {Estado}";
        }
    }
}
