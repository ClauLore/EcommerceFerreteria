using EcommerceFerreteria.Abstracta;
using EcommerceFerreteria.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcommerceFerreteria.Modelos
{
    public class Producto:Auditoria
    {
        private static int _nextId = 1;

        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Estado { get; set; }

        public CategoriaProducto CategoriaProducto { get; set; }

        public Producto()
        {
            Id = _nextId++;
        }

        public override string ToString()
        {
            return $"Producto # {Id}: Descripción: {Descripcion}, Precio: {Precio}, Categoría: {CategoriaProducto}, Stock: {Stock}";
        }
    }
}
