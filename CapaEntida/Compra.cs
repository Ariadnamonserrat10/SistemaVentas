using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntida
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public Usuario oUsuario { get; set; }
        public Proveedor oProvedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
