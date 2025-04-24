using EcommerceFerreteria.Abstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Modelos
{
    public class VentaDetalle:CamposAuditoria
    {
        public int Item { get; set; }
        public int Cantidad { get; set; }
        public Producto? Producto { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Subtotal { get; set; }
            
    }
}
