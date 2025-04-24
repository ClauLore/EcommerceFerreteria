using EcommerceFerreteria.Abstracta;
using EcommerceFerreteria.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Modelos
{
    public class Venta: CamposAuditoria
    {
        private static int _nextId=1;

        public int Id {  get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string SerieDoc { get; set; }
        public string NumeroDoc { get; set; }

        public Cliente Cliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public Estado Estado { get; set; }

        public CategoriaProducto CategoriaProducto { get; set; }
        public Vendedor Vendedor { get; set; }

        public List<VentaDetalle> ventasDetalle {  get; set; }

        public Venta()
        {
            Id = _nextId++;
            FechaVenta = DateTime.Now;
        }

    }
}
