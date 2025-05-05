using EcommerceFerreteria.Abstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Modelos
{
    public class VentaDetalle:Auditoria
    {
        private static int _nextId = 1;

        public int Id { get; set; }
        public int Item { get; set; }
        public int Cantidad { get; set; }
        public int IdProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Subtotal { get; set; }

        public VentaDetalle()
        {
            Id = _nextId++;
        }
    }
}
