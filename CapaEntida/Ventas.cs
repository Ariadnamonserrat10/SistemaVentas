using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntida
{
    public class Ventas
    {
        public int IdVenta { get; set; }
        public Usuario oUsuario { get; set; }
        public string TipoDocumento { get; set; }
        public string NumDocumento { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public List<DetallesVentas> oDetallesVentas { get; set; }
        public string FechaRegistro { get; set; }
    }
}
