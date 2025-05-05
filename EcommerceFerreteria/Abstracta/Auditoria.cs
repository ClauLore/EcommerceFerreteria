using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceFerreteria.Abstracta
{
    public abstract class Auditoria
    {
       public DateTime FechaCreacion = DateTime.Now;
       public DateTime FechaModificacion;
    }
}
